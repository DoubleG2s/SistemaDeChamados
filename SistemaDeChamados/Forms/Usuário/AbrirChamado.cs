using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeChamados.Services;
using SistemaDeChamados.Utils;

namespace SistemaDeChamados.Forms.Usuário
{
    public partial class AbrirChamado : Form
    {
        public AbrirChamado()
        {
            InitializeComponent();
        }

        private async void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloChamado.Text.Trim();
            string descricao = txtDescri.Text.Trim();

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha todos os campos antes de abrir um chamado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool sucesso = await ChamadoApiService.CriarChamadoAsync(titulo, descricao, UsuarioLogado.Id);

                if (sucesso)
                {
                    MessageBox.Show("Chamado aberto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTituloChamado.Clear();
                    txtDescri.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao abrir chamado. Verifique a API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


