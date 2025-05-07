using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using SistemaDeChamados.Services;

public static class MensagemChatApiService
{
    private static readonly HttpClient client = new();
    private const string baseUrl = "https://piktjsohpesmxzmtnvdq.supabase.co/rest/v1";
    private const string tabelaMensagens = "mensagens_chat"; // Para inserir
    private const string viewMensagensComNomes = "mensagens_com_nomes"; // Para ler
    private const string apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBpa3Rqc29ocGVzbXh6bXRudmRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDU5MjY1NzgsImV4cCI6MjA2MTUwMjU3OH0.xvROk_sJ2kfy7RyZo46yM-Nj08qQKyEAz37WsSBM6Pk"; // sua chave

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
        ConfigurarCabecalhos();

        var url = $"{baseUrl}/{viewMensagensComNomes}?id_chamado=eq.{idChamado}&order=data_envio.asc";

        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<MensagemChat>>(json);
    }

    public static async Task<bool> EnviarMensagemAsync(MensagemChat mensagem)
    {
        ConfigurarCabecalhos(preferMinimal: true);

        var payload = new
        {
            id_chamado = mensagem.id_chamado,
            remetente_id = mensagem.remetente_id,
            destinatario_id = mensagem.destinatario_id,
            mensagem = mensagem.mensagem,
            data_envio = mensagem.data_envio == DateTime.MinValue ? DateTime.UtcNow : mensagem.data_envio
        };

        var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"{baseUrl}/{tabelaMensagens}", content);
        return response.IsSuccessStatusCode;
    }
}
