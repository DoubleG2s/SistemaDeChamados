using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeChamados.Data
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=SeF2ew5xutre;Database=db_sistema_chamados";

        public static void TestarConexao()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    Debug.WriteLine("Conexão bem-sucedida com o banco de dados PostgreSQL!");
                    MessageBox.Show("Conexão bem-sucedida com o banco de dados PostgreSQL!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao conectar ao banco: " + ex.Message);
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message);
            }
        }
    }
}
