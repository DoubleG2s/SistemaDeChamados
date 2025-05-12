using SistemaDeChamados.ChatItens;
using SistemaDeChamados.Services;
using SistemaDeChamados.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private int ultimoIdMensagem = -1;
        private bool carregandoMensagens = false;

        public FormPopupChat()
        {
            InitializeComponent();
            this.FormClosed += FormPopupChat_FormClosed;

            // Configuração inicial do FlowLayoutPanel
            flowlpMensagens.AutoScroll = true;
            flowlpMensagens.FlowDirection = FlowDirection.TopDown;
            flowlpMensagens.WrapContents = false;
        }

        private async void CarregarMensagens()
        {
            if (carregandoMensagens) return;

            carregandoMensagens = true;
            try
            {
                var mensagens = await MensagemChatApiService.ObterNovasMensagensAsync(IdChamado, ultimoIdMensagem);

                if (mensagens == null || mensagens.Count == 0)
                {
                    carregandoMensagens = false;
                    return;
                }

                this.Invoke((MethodInvoker)delegate {
                    foreach (var msg in mensagens.OrderBy(m => m.id))
                    {
                        AdicionarMensagemNaTela(msg);
                        ultimoIdMensagem = Math.Max(ultimoIdMensagem, msg.id);
                    }

                    if (flowlpMensagens.VerticalScroll.Value >
                        flowlpMensagens.VerticalScroll.Maximum - flowlpMensagens.Height - 50)
                    {
                        flowlpMensagens.ScrollControlIntoView(
                            flowlpMensagens.Controls[flowlpMensagens.Controls.Count - 1]);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar mensagens: {ex.Message}");
            }
            finally
            {
                carregandoMensagens = false;
            }
        }

        private Control CriarBubbleMensagem(MensagemChat msg)
        {
            if (msg.remetente_id == UsuarioAtualId)
            {
                return new BubbleMensagemEnviada
                {
                    Remetente = msg.remetente_nome,
                    Mensagem = msg.mensagem,
                    Hora = msg.data_envio.ToLocalTime().ToString("HH:mm")
                };
            }
            else
            {
                return new BubbleMensagemRecebida
                {
                    Remetente = msg.remetente_nome,
                    Mensagem = msg.mensagem,
                    Hora = msg.data_envio.ToLocalTime().ToString("HH:mm")
                };
            }
        }

        private void AdicionarMensagemNaTela(MensagemChat msg)
        {
            var bubble = CriarBubbleMensagem(msg);
            var wrapper = new Panel
            {
                Width = flowlpMensagens.ClientSize.Width - 30,
                Height = bubble.Height + 5,
                Padding = new Padding(0),
                Margin = new Padding(0, 6, 0, 6)
            };

            if (msg.remetente_id == UsuarioAtualId)
            {
                bubble.Location = new Point(wrapper.Width - bubble.Width - 10, 0);
            }
            else
            {
                bubble.Location = new Point(10, 0);
            }

            wrapper.Controls.Add(bubble);
            flowlpMensagens.Controls.Add(wrapper);
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensagem.Text)) return;

            var mensagemTexto = txtMensagem.Text.Trim();
            txtMensagem.Clear();

            try
            {
                var novaMsg = new MensagemChat
                {
                    id_chamado = IdChamado,
                    remetente_id = UsuarioAtualId,
                    destinatario_id = DestinatarioId,
                    mensagem = mensagemTexto,
                    data_envio = DateTime.UtcNow,
                    remetente_nome = UsuarioLogado.Nome
                };

                //AdicionarMensagemNaTela(novaMsg);
                ultimoIdMensagem = Math.Max(ultimoIdMensagem, novaMsg.id);

                bool sucesso = await MensagemChatApiService.EnviarMensagemAsync(novaMsg);

                if (!sucesso)
                {
                    MessageBox.Show("Falha ao enviar mensagem. Tente novamente.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar mensagem: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FormPopupChat_Load(object sender, EventArgs e)
        {
            try
            {
                var mensagens = await MensagemChatApiService.ObterMensagensAsync(IdChamado);

                // Descobre o nome da outra pessoa com quem estou conversando
                var msgRelacionada = mensagens.FirstOrDefault(m =>
                    (m.remetente_id == UsuarioAtualId && m.destinatario_id == DestinatarioId) ||
                    (m.remetente_id == DestinatarioId && m.destinatario_id == UsuarioAtualId)
                );

                if (msgRelacionada != null)
                {
                    // Se eu sou o remetente, mostro o destinatário. Senão, mostro o remetente.
                    string nomeOutro = msgRelacionada.remetente_id == UsuarioAtualId
                        ? msgRelacionada.destinatario_nome
                        : msgRelacionada.remetente_nome;

                    lblNomeUsuario.Text = nomeOutro;
                }
                else
                {
                    lblNomeUsuario.Text = $"Usuário #{DestinatarioId}";
                }

                // Carrega mensagens e inicia timer
                CarregarMensagens();
                timer = new Timer { Interval = 2000 };
                timer.Tick += (s, ev) => CarregarMensagens();
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar chat: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormPopupChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer?.Stop();
            timer?.Dispose();
        }

        private void panelTituloChat_Click(object sender, EventArgs e) => this.Close();

        private void btnFechar_Click(object sender, EventArgs e) => this.Close();
    }
}