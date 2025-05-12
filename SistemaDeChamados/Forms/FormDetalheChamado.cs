using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SistemaDeChamados.Services;
using SistemaDeChamados.Forms;
using SistemaDeChamados.Utils;
using System.Threading.Tasks;

namespace SistemaDeChamados
{
    public partial class FormDetalheChamado : Form
    {
        private FormPopupChat popupChat;
        private int chamadoId;
        private int usuarioIdChamado;
        private int destinoY;
        private int velocidadeSubida = 10;

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
            cbClassificacao.Text = "Classificar";
        }

        private void ConfigurarComboBoxPrioridade()
        {
            cbPrioridade.Items.Clear();
            cbPrioridade.Items.AddRange(new string[] { "Urgente", "Alta", "Neutra", "Baixa" });
            cbPrioridade.Text = "Prioridade";
        }

        private void PreencherLabels(object dadosChamado)
        {
            try
            {
                var props = dadosChamado.GetType().GetProperties();
                int? idChamado = null;

                foreach (var prop in props)
                {
                    string name = prop.Name.ToLower();

                    if (name == "id")
                    {
                        this.chamadoId = (int)prop.GetValue(dadosChamado);
                        labelId.Text = "#" + chamadoId;
                        idChamado = chamadoId;
                    }
                    else if (name == "titulo") labelTitulo.Text = prop.GetValue(dadosChamado)?.ToString();
                    else if (name == "data_registro" && DateTime.TryParse(prop.GetValue(dadosChamado)?.ToString(), out DateTime data))
                        labelDataRegistro.Text = data.ToString("dd/MM/yyyy HH:mm");
                    else if (name == "descricao") labelDescri.Text = prop.GetValue(dadosChamado)?.ToString();
                    else if (name == "usuario_nome") labelUsuario.Text = prop.GetValue(dadosChamado)?.ToString();
                    else if (name == "usuario_id") this.usuarioIdChamado = (int)prop.GetValue(dadosChamado);
                }

                bool isAdmin = UsuarioLogado.Id != usuarioIdChamado;
                cbClassificacao.Visible = isAdmin;
                cbPrioridade.Visible = isAdmin;

                // REMOVIDA a chamada para InicializarChat() aqui
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar detalhes do chamado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) => this.Close();

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private async void cbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(labelId.Text.TrimStart('#'), out int idChamado))
            {
                string novaClassificacao = cbClassificacao.SelectedItem.ToString();
                bool sucesso = await ChamadoApiService.AtualizarClassificacaoAsync(idChamado, novaClassificacao);

                if (sucesso)
                {
                    MessageBox.Show("Classificação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnChamadoAtualizado?.Invoke();
                }
                else MessageBox.Show("Erro ao atualizar classificação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event Action OnChamadoAtualizado;

        private async void cbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(labelId.Text.TrimStart('#'), out int idChamado))
            {
                string novaPrioridade = cbPrioridade.SelectedItem.ToString();
                bool sucesso = await ChamadoApiService.AtualizarPrioridadeAsync(idChamado, novaPrioridade);

                if (sucesso)
                {
                    MessageBox.Show("Prioridade atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnChamadoAtualizado?.Invoke();
                }
                else MessageBox.Show("Erro ao atualizar prioridade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private FormPopupChat chatForm;

        private async void lblExpandirChat_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (chatForm == null || chatForm.IsDisposed)
            //    {
            //        // Verifica se o usuário logado é admin
            //        bool isAdmin = UsuarioLogado.TipoUsuario?.Equals("Admin", StringComparison.OrdinalIgnoreCase) ?? false;

            //        // Determina o destinatário - se for admin, conversa com quem abriu o chamado, senão com admin
            //        int destinatarioId = isAdmin ? usuarioIdChamado : await ObterIdAdminResponsavel();

            //        chatForm = new FormPopupChat
            //        {
            //            IdChamado = chamadoId,
            //            UsuarioAtualId = UsuarioLogado.Id,
            //            DestinatarioId = destinatarioId
            //        };

            //        var posX = this.Location.X + this.Width - chatForm.Width - 30;
            //        var posY = this.Location.Y + this.Height - chatForm.Height - 60;

            //        chatForm.StartPosition = FormStartPosition.Manual;
            //        chatForm.Location = new Point(posX, posY);
            //        chatForm.Show();
            //    }
            //    else
            //    {
            //        chatForm.BringToFront();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erro ao abrir chat: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private async Task<int> ObterIdAdminResponsavel()
        {
            try
            {
                var usuarios = await UsuarioApiService.ObterUsuariosAsync();
                var admin = usuarios?.FirstOrDefault(u =>
                    u.tipo_usuario.Equals("Admin", StringComparison.OrdinalIgnoreCase) &&
                    u.status.Equals("Ativo", StringComparison.OrdinalIgnoreCase));

                if (admin != null)
                {
                    return admin.id;
                }

                // Fallback - busca qualquer admin (mesmo inativo)
                var qualquerAdmin = usuarios?.FirstOrDefault(u =>
                    u.tipo_usuario.Equals("Admin", StringComparison.OrdinalIgnoreCase));

                if (qualquerAdmin != null)
                {
                    return qualquerAdmin.id;
                }

                throw new Exception("Nenhum administrador encontrado no sistema.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter ID do admin: {ex.Message}");
                throw; // Re-lança a exceção para ser tratada no método chamador
            }
        }

        private void timerAbrirChat_Tick(object sender, EventArgs e)
        {
            // Mantido caso ainda seja necessário para alguma animação
        }

        private void FormDetalheChamado_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (popupChat != null && !popupChat.IsDisposed)
                popupChat.Close();
        }

        private async void btnChat_Click(object sender, EventArgs e)
        {
            try
            {
                if (chatForm == null || chatForm.IsDisposed)
                {
                    // Verifica se o usuário logado é admin
                    bool isAdmin = UsuarioLogado.TipoUsuario?.Equals("Admin", StringComparison.OrdinalIgnoreCase) ?? false;

                    // Determina o destinatário - se for admin, conversa com quem abriu o chamado, senão com admin
                    int destinatarioId = isAdmin ? usuarioIdChamado : await ObterIdAdminResponsavel();

                    chatForm = new FormPopupChat
                    {
                        IdChamado = chamadoId,
                        UsuarioAtualId = UsuarioLogado.Id,
                        DestinatarioId = destinatarioId
                    };

                    var posX = this.Location.X + this.Width - chatForm.Width - 30;
                    var posY = this.Location.Y + this.Height - chatForm.Height - 60;

                    chatForm.StartPosition = FormStartPosition.Manual;
                    chatForm.Location = new Point(posX, posY);
                    chatForm.Show();
                }
                else
                {
                    chatForm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir chat: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}