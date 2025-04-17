using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SistemaDeChamados.Utils;

namespace SistemaDeChamados.Forms.Usuário
{
    public partial class AbrirChamado : Form
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=SeF2ew5xutre;Database=db_sistema_chamados";
        public AbrirChamado()
        {
            InitializeComponent();
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            // Capturar valores dos campos
            string titulo = txtTituloChamado.Text;
            string descricao = txtDescri.Text;  // Correção aqui
            string usuarioLogado = UsuarioLogado.Nome; // Obtém o nome do usuário logado
            DateTime dataRegistro = DateTime.Now;
            DateTime dataAtualizacao = dataRegistro;
            string status = "ABERTO"; // Status padrão ao abrir chamado

            // Validação básica
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha todos os campos antes de abrir um chamado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO chamados 
                        (TITULO, DESCRICAO, DATA_REGISTRO, DATA_ATUALIZACAO, USUARIO, CLASSIFICACAO, CATEGORIA, STATUS) 
                        VALUES (@titulo, @descricao, @dataRegistro, @dataAtualizacao, @usuario, NULL, NULL, @status)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@dataRegistro", dataRegistro);
                        cmd.Parameters.AddWithValue("@dataAtualizacao", dataAtualizacao);
                        cmd.Parameters.AddWithValue("@usuario", UsuarioLogado.Id);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Chamado aberto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


