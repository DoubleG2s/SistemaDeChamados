using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace SistemaDeChamados.Utils
{
    public static class HashHelper
    {
        public static string HashSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public static bool VerificarSenha(string senhaDigitada, string senhaHash)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaHash);
        }
    }
}
