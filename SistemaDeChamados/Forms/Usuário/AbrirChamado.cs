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
            LoadChamadosDoUsuarioAsync();
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

        private async void LoadChamadosDoUsuarioAsync()
        {
            try
            {
                flowLayoutPanelMeusChamados.Controls.Clear();

                var todosChamados = await ChamadoApiService.ObterChamadosAsync();

                var meusChamados = todosChamados
                    .Where(c => c.usuario_id == UsuarioLogado.Id && c.status.Equals("aberto", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (meusChamados.Count == 0)
                {
                    Label lblVazio = new Label
                    {
                        Text = "Você não possui chamados abertos.",
                        Font = new Font("Bahnschrift", 12),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Margin = new Padding(10)
                    };
                    flowLayoutPanelMeusChamados.Controls.Add(lblVazio);
                    return;
                }

                foreach (var chamado in meusChamados)
                {
                    CriarCardChamadoUsuario(chamado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seus chamados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CriarCardChamadoUsuario(Chamado chamado)
        {
            Panel card = new Panel
            {
                Size = new Size(900, 100),
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                //adapte automaticamente ao tamanho do container
                Dock = DockStyle.Top,
                Width = flowLayoutPanelMeusChamados.Width - 25
            };

            Label lblTitulo = new Label
            {
                Text = chamado.titulo,
                Font = new Font("Bahnschrift", 11, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblData = new Label
            {
                Text = chamado.data_registro.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Bahnschrift", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(10, 35),
                AutoSize = true
            };

            Label lblStatus = new Label
            {
                Text = chamado.status,
                Font = new Font("Bahnschrift", 9),
                ForeColor = Color.Orange,
                Location = new Point(10, 60),
                AutoSize = true
            };

            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblData);
            card.Controls.Add(lblStatus);

            flowLayoutPanelMeusChamados.Controls.Add(card);
        }


    }
}


