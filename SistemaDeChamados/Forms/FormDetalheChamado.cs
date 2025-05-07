using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SistemaDeChamados.Services;
using SistemaDeChamados.Forms;
using SistemaDeChamados.Utils;


namespace SistemaDeChamados
{
    public partial class FormDetalheChamado : Form
    {
        private FormPopupChat popupChat;
        private int chamadoId;
        private int usuarioIdChamado;
        private int destinoY;
        private int velocidadeSubida = 10;


        //tornar o panelTitleBar arrastável
        // Drag Form API Windows
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public FormDetalheChamado(object dadosChamado)
        {
            InitializeComponent();
            ConfigurarComboBoxClassificacao();
            ConfigurarComboBoxPrioridade();
            this.Text = "Detalhes do Chamado";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(800, 600);
            this.MinimumSize = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            PreencherLabels(dadosChamado);
        }
        private int ObterIdChamado()
        {
            return int.TryParse(labelId.Text.TrimStart('#'), out int id) ? id : 0;
        }
        private void ConfigurarComboBoxClassificacao()
        {
            cbClassificacao.Items.Clear();
            cbClassificacao.Items.AddRange(new string[] { "Hardware", "Software", "Periféricos", "Microsoft Office" });
            cbClassificacao.Text = "Classificar"; // Texto inicial visível
        }

        private void ConfigurarComboBoxPrioridade()
        {
            cbPrioridade.Items.Clear();
            cbPrioridade.Items.AddRange(new string[] { "Urgente", "Alta", "Neutra", "Baixa" });
            cbPrioridade.Text = "Prioridade";
        }



        private void PreencherLabels(object dadosChamado)
        {
            var props = dadosChamado.GetType().GetProperties();
            int? usuarioIdChamado = null;
            int? idChamado = null;

            foreach (var prop in props)
            {
                if (prop.Name.ToLower() == "id" && labelId != null)
                {
                    this.chamadoId = (int)prop.GetValue(dadosChamado);
                    labelId.Text = "#" + chamadoId;
                }
                else if (prop.Name.ToLower() == "titulo" && labelTitulo != null)
                {
                    labelTitulo.Text = prop.GetValue(dadosChamado)?.ToString();
                }
                else if (prop.Name.ToLower() == "data_registro" && labelDataRegistro != null)
                {
                    if (DateTime.TryParse(prop.GetValue(dadosChamado)?.ToString(), out DateTime data))
                    {
                        labelDataRegistro.Text = data.ToString("dd/MM/yyyy HH:mm");
                    }
                    else
                    {
                        labelDataRegistro.Text = prop.GetValue(dadosChamado)?.ToString();
                    }
                }
                else if (prop.Name.ToLower() == "descricao" && labelDescri != null)
                {
                    labelDescri.Text = prop.GetValue(dadosChamado)?.ToString();
                }
                else if (prop.Name.ToLower() == "usuario_nome" && labelUsuario != null)
                {
                    labelUsuario.Text = prop.GetValue(dadosChamado)?.ToString();
                }
                else if (prop.Name.ToLower() == "usuario_id")
                {
                    this.usuarioIdChamado = (int)prop.GetValue(dadosChamado);
                }

            }

            // Só exibe o chat se tudo estiver OK
            if (idChamado.HasValue && usuarioIdChamado.HasValue)
            {
                popupChat = new FormPopupChat
                {
                    IdChamado = idChamado.Value,
                    UsuarioAtualId = UsuarioLogado.Id,
                    DestinatarioId = usuarioIdChamado.Value
                };

                // Posiciona no canto inferior direito da tela pai
                popupChat.StartPosition = FormStartPosition.Manual;
                var parentBounds = this.Bounds;
                popupChat.Location = new Point(
                    parentBounds.Right - popupChat.Width - 20,
                    parentBounds.Bottom - popupChat.Height - 50
                );

                popupChat.Show();
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar janela
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private async void cbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string novaClassificacao = cbClassificacao.SelectedItem.ToString();

            // Extrai o ID do chamado da label (ex: "#12" -> 12)
            if (int.TryParse(labelId.Text.TrimStart('#'), out int idChamado))
            {
                bool sucesso = await ChamadoApiService.AtualizarClassificacaoAsync(idChamado, novaClassificacao);

                if (sucesso)
                {
                    MessageBox.Show("Classificação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnChamadoAtualizado?.Invoke();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar classificação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public event Action OnChamadoAtualizado;

        private async void cbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string novaPrioridade = cbPrioridade.SelectedItem.ToString();

            if (int.TryParse(labelId.Text.TrimStart('#'), out int idChamado))
            {
                bool sucesso = await ChamadoApiService.AtualizarPrioridadeAsync(idChamado, novaPrioridade);

                if (sucesso)
                {
                    MessageBox.Show("Prioridade atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnChamadoAtualizado?.Invoke();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar prioridade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private FormPopupChat chatForm;
        private void lblExpandirChat_Click(object sender, EventArgs e)
        {
            if (chatForm == null || chatForm.IsDisposed)
            {
                int idChamado = this.chamadoId;
                int usuarioId = this.usuarioIdChamado;

                chatForm = new FormPopupChat
                {
                    IdChamado = idChamado,
                    UsuarioAtualId = UsuarioLogado.Id,
                    DestinatarioId = usuarioId
                };

                var posX = this.Location.X + this.Width - chatForm.Width - 30;
                var posY = this.Location.Y + this.Height - chatForm.Height - 60;

                chatForm.StartPosition = FormStartPosition.Manual;
                chatForm.Location = new Point(posX, posY);
                chatForm.Show();
            }
        }

        private void timerAbrirChat_Tick(object sender, EventArgs e)
        {
            if (popupChat != null && !popupChat.IsDisposed)
            {
                int yAtual = popupChat.Location.Y;

                if (yAtual > destinoY)
                {
                    popupChat.Location = new Point(popupChat.Location.X, yAtual - velocidadeSubida);
                    popupChat.Opacity = Math.Min(1, popupChat.Opacity + 0.05);
                }
                else
                {
                    popupChat.Location = new Point(popupChat.Location.X, destinoY);
                    popupChat.Opacity = 1;
                    timerAbrirChat.Stop();
                }
            }
        }

        private void FormDetalheChamado_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (popupChat != null && !popupChat.IsDisposed)
            {
                popupChat.Close();
            }
        }
    }
}
