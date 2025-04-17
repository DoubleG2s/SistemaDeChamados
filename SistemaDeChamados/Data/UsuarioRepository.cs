using Npgsql;
using SistemaDeChamados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeChamados.Data
{
    public class UsuarioRepository
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=SeF2ew5xutre;Database=db_sistema_chamados";

        public static void CriarUsuario(string nome, string login, string senha)
        {
            string senhaHash = HashHelper.HashSenha(senha); // Hash da senha

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO USUARIOS (NOME, LOGIN, SENHA) VALUES (@nome, @login, @senha)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
