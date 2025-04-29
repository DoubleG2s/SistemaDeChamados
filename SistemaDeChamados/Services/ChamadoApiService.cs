using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeChamados.Services
{
    public class Chamado
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime? data_atualizacao { get; set; }
        public string status { get; set; }
        public string classificacao { get; set; }
        public string categoria { get; set; }
        public string usuario_nome { get; set; }
    }

    public static class ChamadoApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string baseUrl = "https://piktjsohpesmxzmtnvdq.supabase.co/rest/v1";
        private const string tabelaChamados = "chamados_com_usuario"; // deve ser uma view no Supabase que junta chamados + nome do usuário
        private const string apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBpa3Rqc29ocGVzbXh6bXRudmRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDU5MjY1NzgsImV4cCI6MjA2MTUwMjU3OH0.xvROk_sJ2kfy7RyZo46yM-Nj08qQKyEAz37WsSBM6Pk"; // Mantenha sua chave real aqui

        public static async Task<List<Chamado>> ObterChamadosAsync()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Add("apikey", apiKey);

            string url = $"{baseUrl}/{tabelaChamados}?select=*";

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Chamado>>(json);
        }

        public static async Task<bool> CriarChamadoAsync(string titulo, string descricao, int usuarioId)
        {
            var chamado = new
            {
                titulo = titulo,
                descricao = descricao,
                usuario = usuarioId,
                status = "ABERTO",
                data_registro = DateTime.UtcNow,
                data_atualizacao = DateTime.UtcNow,
                classificacao = (string)null,
                categoria = (string)null
            };

            var json = JsonSerializer.Serialize(chamado);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Add("apikey", apiKey);
            client.DefaultRequestHeaders.Add("Prefer", "return=minimal");

            var response = await client.PostAsync($"{baseUrl}/chamados", content);
            return response.IsSuccessStatusCode;
        }

    }
}
