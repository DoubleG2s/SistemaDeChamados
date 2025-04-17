using Npgsql;
using SistemaDeChamados.Utils;
using SistemaDeChamados.Data;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=SeF2ew5xutre;Database=db_sistema_chamados"))
                {
                    conn.Open();
                    string sql = "SELECT ID, NOME, LOGIN, SENHA, STATUS, TIPO_USUARIO FROM USUARIOS WHERE LOGIN = @login";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Se o usuário for encontrado
                            {
                                int idUsuario = reader.GetInt32(0);
                                string nomeUsuario = reader.GetString(1);
                                string senhaHash = reader["SENHA"].ToString();
                                string status = reader["STATUS"].ToString();
                                string tipoUsuario = reader["TIPO_USUARIO"].ToString();

                                if (HashHelper.VerificarSenha(senha, senhaHash))
                                {
                                    if (status == "Ativo")
                                    {
                                        // **Armazena os dados na sessão**
                                        UsuarioLogado.Id = idUsuario;
                                        UsuarioLogado.Nome = nomeUsuario;

                                        MessageBox.Show($"Bem-vindo, {nomeUsuario}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Hide(); // Esconde a TelaLogin antes de abrir o formulário principal

                                        if (tipoUsuario == "Admin")
                                        {
                                            Form1 formPrincipal = new Form1();
                                            formPrincipal.ShowDialog();
                                        }
                                        else if (tipoUsuario == "Comum")
                                        {
                                            FormUser telaUsuario = new FormUser();
                                            telaUsuario.ShowDialog();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Tipo de usuário desconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        this.Show(); // Se o formulário principal for fechado, reexibe a TelaLogin
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seu usuário está inativo. Entre em contato com o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Login ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar realizar o login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            this.Hide(); // Esconde a tela de login
            telaCadastro.ShowDialog(); // Aguarda o fechamento da TelaCadastro
            this.Show(); // Reexibe a tela de login após fechar o cadastro
        }

        private void panelDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
