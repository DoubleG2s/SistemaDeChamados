using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeChamados.Services
{
    public static class MensagemChatApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string baseUrl = "https://piktjsohpesmxzmtnvdq.supabase.co/rest/v1";
        private const string tabelaMensagens = "mensagens_chat";
        private const string viewMensagensComNomes = "mensagens_com_nomes";
        private const string apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBpa3Rqc29ocGVzbXh6bXRudmRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDU5MjY1NzgsImV4cCI6MjA2MTUwMjU3OH0.xvROk_sJ2kfy7RyZo46yM-Nj08qQKyEAz37WsSBM6Pk";

        private static void ConfigurarCabecalhos(bool preferMinimal = false)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Add("apikey", apiKey);
            if (preferMinimal)
                client.DefaultRequestHeaders.Add("Prefer", "return=minimal");
        }

        public static async Task<List<MensagemChat>> ObterMensagensAsync(int idChamado)
        {
            try
            {
                ConfigurarCabecalhos();
                string url = $"{baseUrl}/{viewMensagensComNomes}?id_chamado=eq.{idChamado}&select=*,remetente:nome,destinatario:nome&order=data_envio.asc";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<List<MensagemChat>>(json, options) ?? new List<MensagemChat>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter mensagens: {ex.Message}");
                return new List<MensagemChat>();
            }
        }

        public static async Task<bool> EnviarMensagemAsync(MensagemChat mensagem)
        {
            try
            {
                ConfigurarCabecalhos(preferMinimal: true);

                var payload = new
                {
                    id_chamado = mensagem.id_chamado,
                    remetente_id = mensagem.remetente_id,
                    destinatario_id = mensagem.destinatario_id,
                    mensagem = mensagem.mensagem,
                    data_envio = DateTime.UtcNow
                };

                var json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{baseUrl}/{tabelaMensagens}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar mensagem: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<MensagemChat>> ObterNovasMensagensAsync(int idChamado, int ultimoIdConhecido)
        {
            try
            {
                ConfigurarCabecalhos();
                string url = $"{baseUrl}/{viewMensagensComNomes}?id_chamado=eq.{idChamado}&id=gt.{ultimoIdConhecido}&order=data_envio.asc";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<List<MensagemChat>>(json, options) ?? new List<MensagemChat>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter novas mensagens: {ex.Message}");
                return new List<MensagemChat>();
            }
        }
    }
}