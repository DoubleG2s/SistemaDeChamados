using SistemaDeChamados.Services;
using SistemaDeChamados.Utils;
using System;
using System.Threading.Tasks;


namespace SistemaDeChamados.Data
{
    public class UsuarioRepository
    {
        public static async Task CriarUsuarioAsync(string nome, string login, string senha)
        {
            string senhaHash = HashHelper.HashSenha(senha);

            bool sucesso = await UsuarioApiService.CriarUsuarioAsync(nome, login, senhaHash);

            if (!sucesso)
            {
                throw new Exception("Erro ao cadastrar usuário na API.");
            }
        }
    }
}
