using SistemaDeChamados.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SistemaDeChamados.Forms
{
    public partial class FormPopupChat : Form
    {
        public int IdChamado { get; set; }
        public int UsuarioAtualId { get; set; }
        public int DestinatarioId { get; set; }

        private Timer timer;

        public FormPopupChat()
        {
            InitializeComponent();
            this.FormClosed += FormPopupChat_FormClosed;
        }

        private void panelTituloChat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CarregarMensagens()
        {
            var mensagens = await MensagemChatApiService.ObterMensagensAsync(IdChamado);
            flowlpMensagens.Controls.Clear();

            foreach (var msg in mensagens)
            {
                bool isMinhaMensagem = msg.remetente_id == UsuarioAtualId;

                var tabela = new TableLayoutPanel
                {
                    AutoSize = true,
                    BackColor = isMinhaMensagem ? Color.LightGreen : Color.LightSkyBlue,
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                    ColumnCount = 1,
                    RowCount = 3,
                    Margin = new Padding(10),
                    Padding = new Padding(8),
                    MaximumSize = new Size(260, 0)
                };

                tabela.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                var lblNome = new Label
                {
                    Text = msg.remetente_nome,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    AutoSize = true
                };

                var lblTexto = new Label
                {
                    Text = msg.mensagem,
                    Font = new Font("Segoe UI", 9),
                    MaximumSize = new Size(240, 0),
                    AutoSize = true
                };

                var lblHora = new Label
                {
                    Text = msg.data_envio.ToString("HH:mm"),
                    Font = new Font("Segoe UI", 7),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Anchor = AnchorStyles.Right
                };

                // Adiciona elementos à tabela
                tabela.Controls.Add(lblNome, 0, 0);
                tabela.Controls.Add(lblTexto, 0, 1);
                tabela.Controls.Add(lblHora, 0, 2);

                // Cria um wrapper para alinhar a bolha
                var wrapper = new Panel
                {
                    Width = flowlpMensagens.Width - 30,
                    AutoSize = true,
                    Padding = new Padding(0)
                };

                tabela.Dock = DockStyle.None;

                if (isMinhaMensagem)
                {
                    tabela.Anchor = AnchorStyles.Right;
                    tabela.Left = wrapper.Width - tabela.PreferredSize.Width - 15;
                }
                else
                {
                    tabela.Anchor = AnchorStyles.Left;
                    tabela.Left = 10;
                }

                wrapper.Controls.Add(tabela);
                flowlpMensagens.Controls.Add(wrapper);
            }

            if (flowlpMensagens.Controls.Count > 0)
            {
                flowlpMensagens.ScrollControlIntoView(flowlpMensagens.Controls[^1]);
            }
        }




        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensagem.Text)) return;

            var novaMsg = new MensagemChat
            {
                id_chamado = IdChamado,
                remetente_id = UsuarioAtualId,
                destinatario_id = DestinatarioId,
                mensagem = txtMensagem.Text.Trim(),
                data_envio = DateTime.UtcNow
            };

            bool sucesso = await MensagemChatApiService.EnviarMensagemAsync(novaMsg);
            if (sucesso)
            {
                txtMensagem.Clear();
                CarregarMensagens();
            }
        }

        private void FormPopupChat_Load(object sender, EventArgs e)
        {
            timer = new Timer
            {
                Interval = 2000
            };
            timer.Tick += (s, ev) => CarregarMensagens();
            timer.Start();
        }

        private void FormPopupChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer?.Stop();
            timer?.Dispose();
        }
    }
}
