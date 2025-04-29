using Npgsql;
using SistemaDeChamados.Services;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaDeChamados.Forms
{
    public partial class FormChamados : Form
    {
        private static string connectionString = "Host=db.piktjsohpesmxzmtnvdq.supabase.co;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=SeF2ew5xutre;" +
            "Database=postgres;" +
            "Ssl Mode=Require;" +
            "Trust Server Certificate=true;";

        public FormChamados()
        {
            InitializeComponent();
            LoadTheme();
            LoadChamado();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private async void LoadChamado()
        {
            try
            {
                flowLayoutPanelChamados.Controls.Clear();

                var chamados = await ChamadoApiService.ObterChamadosAsync();

                if (chamados == null || chamados.Count == 0)
                {
                    Label lblSemChamados = new Label
                    {
                        Text = "Nenhum chamado encontrado",
                        Font = new Font("Bahnschrift", 12, FontStyle.Regular),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Margin = new Padding(10)
                    };
                    flowLayoutPanelChamados.Controls.Add(lblSemChamados);
                    return;
                }

                foreach (var chamado in chamados)
                {
                    CriarCardChamado(chamado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CriarCardChamado(Chamado chamado)
        {
            Panel cardPanel = new Panel
            {
                Size = new Size(1050, 120),
                Margin = new Padding(10, 10, 10, 20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = chamado
            };

            cardPanel.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, cardPanel.ClientRectangle,
                                        Color.LightGray, 1, ButtonBorderStyle.Solid,
                                        Color.LightGray, 1, ButtonBorderStyle.Solid,
                                        Color.LightGray, 1, ButtonBorderStyle.Solid,
                                        Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 4,
                Padding = new Padding(10),
                BackColor = Color.Transparent
            };
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));

            Label lblId = new Label
            {
                Text = "#" + chamado.id,
                Font = new Font("Bahnschrift", 10, FontStyle.Bold),
                ForeColor = ThemeColor.PrimaryColor,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblTitulo = new Label
            {
                Text = chamado.titulo,
                Font = new Font("Bahnschrift", 11, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblStatus = new Label
            {
                Text = chamado.status,
                Font = new Font("Bahnschrift", 9, FontStyle.Regular),
                ForeColor = GetStatusColor(chamado.status),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };

            Label lblData = new Label
            {
                Text = chamado.data_registro.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Bahnschrift", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblUsuario = new Label
            {
                Text = "Por: " + chamado.usuario_nome,
                Font = new Font("Bahnschrift", 9, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button btnDetalhes = new Button
            {
                Text = "Detalhes",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(15, 176, 85),
                Font = new Font("Bahnschrift", 9, FontStyle.Bold),
                Size = new Size(100, 30),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.None
            };
            btnDetalhes.FlatAppearance.BorderSize = 0;
            btnDetalhes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDetalhes.Width, btnDetalhes.Height, 15, 15));
            btnDetalhes.MouseEnter += (sender, e) => btnDetalhes.BackColor = Color.FromArgb(39, 174, 96);
            btnDetalhes.MouseLeave += (sender, e) => btnDetalhes.BackColor = Color.FromArgb(46, 204, 113);
            btnDetalhes.Click += (sender, e) => MostrarDetalhesChamado(chamado);

            tableLayout.Controls.Add(lblId, 0, 0);
            tableLayout.Controls.Add(lblTitulo, 1, 0);
            tableLayout.Controls.Add(lblStatus, 2, 0);
            tableLayout.Controls.Add(lblData, 0, 1);
            tableLayout.Controls.Add(lblUsuario, 1, 1);
            tableLayout.Controls.Add(btnDetalhes, 2, 3);
            btnDetalhes.Margin = new Padding(210, 0, 0, 0);

            cardPanel.Controls.Add(tableLayout);
            flowLayoutPanelChamados.Controls.Add(cardPanel);
        }


        private Color GetStatusColor(string status)
        {
            switch (status.ToLower())
            {
                case "aberto": return Color.Orange;
                case "em andamento": return Color.Blue;
                case "resolvido": return Color.Green;
                case "fechado": return Color.Gray;
                default: return Color.Black;
            }
        }


        // Dicionário para controlar os forms abertos por ID
        private static Dictionary<int, FormDetalheChamado> formsAbertos = new();

        private void MostrarDetalhesChamado(object dadosChamado)
        {
            // Tenta obter o ID do objeto dinamicamente
            var propId = dadosChamado.GetType().GetProperty("id");
            if (propId == null)
            {
                MessageBox.Show("Erro: objeto chamado não contém propriedade 'id'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idChamado = (int)propId.GetValue(dadosChamado);

            // Verifica se já existe um form com esse ID
            if (formsAbertos.ContainsKey(idChamado))
            {
                var formExistente = formsAbertos[idChamado];
                if (formExistente.IsDisposed)
                {
                    formsAbertos.Remove(idChamado); // limpa referência inválida
                }
                else
                {
                    formExistente.BringToFront();
                    formExistente.Focus();
                    return;
                }
            }

            // Cria novo form e registra no dicionário
            var formDetalhe = new FormDetalheChamado(dadosChamado)
            {
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(1120, 620)
            };

            formDetalhe.FormClosed += (s, e) => formsAbertos.Remove(idChamado); // remove da lista ao fechar
            formsAbertos[idChamado] = formDetalhe;

            formDetalhe.Show();
        }


        // Função para bordas arredondadas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}