using SistemaDeChamados.Utils;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaDeChamados.Services
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string status { get; set; }
        public string tipo_usuario { get; set; }
    }

    public class UsuarioApiService
    {
        private static readonly HttpClient client = new HttpClient();

        private const string baseUrl = "https://piktjsohpesmxzmtnvdq.supabase.co/rest/v1";
        private const string tabelaUsuarios = "usuarios";
        private const string apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBpa3Rqc29ocGVzbXh6bXRudmRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDU5MjY1NzgsImV4cCI6MjA2MTUwMjU3OH0.xvROk_sJ2kfy7RyZo46yM-Nj08qQKyEAz37WsSBM6Pk";

        public static async Task<List<Usuario>> ObterUsuariosAsync()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Add("apikey", apiKey);

            string url = $"{baseUrl}/usuarios?select=id,nome,login,tipo_usuario,status";
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Usuario>>(json);
        }

        public static async Task<int?> ObterIdAdminAtivoAsync()
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.DefaultRequestHeaders.Add("apikey", apiKey);

                string url = $"{baseUrl}/{tabelaUsuarios}?tipo_usuario=eq.Admin&status=eq.Ativo&select=id&limit=1";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var admins = JsonSerializer.Deserialize<List<Usuario>>(json);

                return admins?.FirstOrDefault()?.id;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<string> ObterNomeUsuarioAsync(int usuarioId)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.DefaultRequestHeaders.Add("apikey", apiKey);

                string url = $"{baseUrl}/{tabelaUsuarios}?id=eq.{usuarioId}&select=nome";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                return usuarios?.FirstOrDefault()?.nome;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<(bool sucesso, string mensagem, Usuario usuario)> AutenticarUsuarioAsync(string login, string senha)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Add("apikey", apiKey);

            var response = await client.GetAsync($"{baseUrl}/{tabelaUsuarios}?login=eq.{login}&select=*");

            if (!response.IsSuccessStatusCode)
                return (false, "Erro ao consultar API.", null);

            var content = await response.Content.ReadAsStringAsync();
            var usuarios = JsonSerializer.Deserialize<List<Usuario>>(content);

            if (usuarios == null || usuarios.Count == 0)
                return (false, "Usuário não encontrado.", null);

            var usuario = usuarios[0];

            if (!HashHelper.VerificarSenha(senha, usuario.senha))
                return (false, "Senha incorreta.", null);

            if (usuario.status != "Ativo")
                return (false, "Usuário inativo.", null);

            return (true, "Login bem-sucedido.", usuario);
        }

        public static async Task<bool> CriarUsuarioAsync(string nome, string login, string senhaHash)
        {
            var usuario = new
            {
                nome,
                login,
                senha = senhaHash,
                status = "Ativo",
                tipo_usuario = "Comum"
            };

            var json = JsonSerializer.Serialize(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            client.DefaultRequestHeaders.Add("apikey", apiKey);
            client.DefaultRequestHeaders.Add("Prefer", "return=minimal");

            var response = await client.PostAsync($"{baseUrl}/{tabelaUsuarios}", content);
            return response.IsSuccessStatusCode;
        }
    }
}