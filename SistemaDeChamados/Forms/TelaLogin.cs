using Npgsql;
using SistemaDeChamados.Utils;
using SistemaDeChamados.Data;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SistemaDeChamados.Services;
using System.Threading.Tasks;

namespace SistemaDeChamados.Forms
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            this.Opacity = 0; // Começa invisível
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 30; // Velocidade do efeito
            timer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05; // Aumenta opacidade gradualmente
                }
                else
                {
                    timer.Stop(); // Para o efeito quando atingir 100%
                }
            };
            timer.Start();
        }



        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string login = txtUsername.Text.Trim();
            string senha = txtPass.Text.Trim();

            // Validação para verificar se os campos não estão vazios
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha o login e a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resultado = await UsuarioApiService.AutenticarUsuarioAsync(login, senha);

                if (!resultado.sucesso)
                {
                    MessageBox.Show(resultado.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var usuario = resultado.usuario;
                UsuarioLogado.Id = usuario.id;
                UsuarioLogado.Nome = usuario.nome;

                MessageBox.Show($"Bem-vindo, {usuario.nome}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                if (usuario.tipo_usuario == "Admin")
                {
                    Form1 formPrincipal = new Form1();
                    formPrincipal.ShowDialog();
                }
                else if (usuario.tipo_usuario == "Comum")
                {
                    FormUser telaUsuario = new FormUser();
                    telaUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tipo de usuário desconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar realizar o login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (TelaCadastro telaCadastro = new TelaCadastro())
            {
                telaCadastro.ShowDialog();
            }

            // Se o form ainda estiver válido, reexibe
            if (!this.IsDisposed) this.Show();
        }

        private void panelDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkMostrarSenha.Checked ? '\0' : '●';

            // Mantém o foco no campo de senha
            txtPass.Focus();
            txtPass.SelectionStart = txtPass.Text.Length; // Move o cursor para o fim
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa todos os campos
            txtUsername.Clear();
            txtPass.Clear();
            txtUsername.Focus();
        }
    }
}
