using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeChamados.Data;

namespace SistemaDeChamados.Forms
{

    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Pegando os valores dos campos
            string nome = txtNome.Text.Trim();
            string login = txtLogin.Text.Trim();
            string senha = txtPass.Text.Trim();
            string confirmacaoSenha = txtConfPass.Text.Trim();

            // Validação simples
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmacaoSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificando se as senhas são iguais
            if (senha != confirmacaoSenha)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama o método para criar o usuário
            try
            {
                using var _ = UsuarioRepository.CriarUsuarioAsync(nome, login, senha);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos após o cadastro
                txtNome.Clear();
                txtLogin.Clear();
                txtPass.Clear();
                txtConfPass.Clear();

                // Volta para a tela de login
                Form telaLogin = new TelaLogin();
                telaLogin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblBackLogin_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            this.Hide(); // Esconde a tela de login
            telaLogin.ShowDialog(); // Aguarda o fechamento da TelaCadastro
            this.Show(); // Reexibe a tela de login após fechar o cadastro
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Define o caractere de senha com base na checkbox
            char senhaChar = checkMostrarSenha.Checked ? '\0' : '●';
            txtPass.PasswordChar = senhaChar;
            txtConfPass.PasswordChar = senhaChar;

            // Mantém o foco no campo que estava ativo
            if (txtPass.Focused)
            {
                txtPass.Focus();
                txtPass.SelectionStart = txtPass.Text.Length;
            }
            else if (txtConfPass.Focused)
            {
                txtConfPass.Focus();
                txtConfPass.SelectionStart = txtConfPass.Text.Length;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa todos os campos
            txtNome.Clear();
            txtLogin.Clear();
            txtPass.Clear();
            txtConfPass.Clear();
            txtNome.Focus(); // Foca no campo Nome
        }
    }
}
