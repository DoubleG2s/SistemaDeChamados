using System;

namespace SistemaDeChamados.Utils
{
    public static class UsuarioLogado
    {
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string TipoUsuario { get; set; } // Adicionado para controle de tipo de usuário

        // Método para limpar os dados ao fazer logout
        public static void Limpar()
        {
            Id = 0;
            Nome = string.Empty;
            TipoUsuario = string.Empty;
        }
    }
}