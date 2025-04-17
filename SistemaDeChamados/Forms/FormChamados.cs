using Npgsql;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaDeChamados.Forms
{
    public partial class FormChamados : Form
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=SeF2ew5xutre;Database=db_sistema_chamados";

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

        private void LoadChamado()
        {
            try
            {
                flowLayoutPanelChamados.Controls.Clear();

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT c.ID, c.TITULO, c.DESCRICAO, c.DATA_REGISTRO, 
                                   c.DATA_ATUALIZACAO, u.NOME AS USUARIO, 
                                   c.STATUS, c.CLASSIFICACAO, c.CATEGORIA
                            FROM chamados c
                            JOIN usuarios u ON c.USUARIO = u.ID
                            ORDER BY c.DATA_REGISTRO DESC";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
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

                            while (reader.Read())
                            {
                                CriarCardChamado(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CriarCardChamado(NpgsqlDataReader reader)
        {
            // Painel principal do card (aumentado para 120px de altura)
            Panel cardPanel = new Panel
            {
                Size = new Size(1050, 120),
                Margin = new Padding(10, 10, 10, 20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = new
                {
                    Id = reader["id"].ToString(),
                    Titulo = reader["titulo"].ToString(),
                    Descricao = reader["descricao"].ToString(),
                    DataRegistro = Convert.ToDateTime(reader["data_registro"]).ToString("dd/MM/yyyy HH:mm"),
                    DataAtualizacao = reader["data_atualizacao"] is DBNull ? "Nunca atualizado" :
                                      Convert.ToDateTime(reader["data_atualizacao"]).ToString("dd/MM/yyyy HH:mm"),
                    Usuario = reader["usuario"].ToString(),
                    Status = reader["status"].ToString(),
                    Classificacao = reader["classificacao"].ToString(),
                    Categoria = reader["categoria"].ToString()
                }
            };

            // Sombra simulada
            cardPanel.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, cardPanel.ClientRectangle,
                                      Color.LightGray, 1, ButtonBorderStyle.Solid,
                                      Color.LightGray, 1, ButtonBorderStyle.Solid,
                                      Color.LightGray, 1, ButtonBorderStyle.Solid,
                                      Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            // Layout interno (4 linhas para incluir o botão)
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

            // Linha 1: ID, Título, Status
            Label lblId = new Label
            {
                Text = "#" + reader["id"].ToString(),
                Font = new Font("Bahnschrift", 10, FontStyle.Bold),
                ForeColor = ThemeColor.PrimaryColor,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblTitulo = new Label
            {
                Text = reader["titulo"].ToString(),
                Font = new Font("Bahnschrift", 11, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblStatus = new Label
            {
                Text = reader["status"].ToString(),
                Font = new Font("Bahnschrift", 9, FontStyle.Regular),
                ForeColor = GetStatusColor(reader["status"].ToString()),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Linha 2: Data e Usuário
            Label lblData = new Label
            {
                Text = Convert.ToDateTime(reader["data_registro"]).ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Bahnschrift", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblUsuario = new Label
            {
                Text = "Por: " + reader["usuario"].ToString(),
                Font = new Font("Bahnschrift", 9, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Botão "Detalhes"
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
            btnDetalhes.Click += (sender, e) => MostrarDetalhesChamado(cardPanel.Tag);

            // Adiciona controles ao TableLayout
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

        private void MostrarDetalhesChamado(object dadosChamado)
        {
            var props = dadosChamado.GetType().GetProperties();
            string detalhes = "🔍 Detalhes do Chamado\n\n";
            foreach (var prop in props)
            {
                detalhes += $"• {prop.Name.PadRight(15)}: {prop.GetValue(dadosChamado)}\n";
            }
            MessageBox.Show(detalhes, "Detalhes do Chamado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Função para bordas arredondadas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}