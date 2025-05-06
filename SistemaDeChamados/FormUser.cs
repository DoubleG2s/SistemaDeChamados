using SistemaDeChamados.Forms;
using SistemaDeChamados.Forms.OptionsConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SistemaDeChamados
{
    public partial class FormUser : Form
    {

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Fields
        private Button currentButton;
        private Form activeForm;

        public FormUser()
        {
            InitializeComponent();
            ThemeColor.SetDefaultTheme(); // define a cor #099CFF como padrão
            ApplyTheme();                 // aplica no visual do formulário

            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ApplyTheme()
        {
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;
            panelLogo.BackColor = Color.FromArgb(39, 39, 58); // inativo até clicar

            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76); // estilo "inativo"
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }


        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ThemeColor.PrimaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    panelTitleBar.BackColor = ThemeColor.PrimaryColor;
                    panelLogo.BackColor = ThemeColor.SecondaryColor;
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            Debug.WriteLine($"Tentando abrir: {childForm.GetType().Name}");

            if (activeForm != null)
            {
                Debug.WriteLine($"Fechando: {activeForm.GetType().Name}");
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //panelDesktop.Controls.Clear();
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

            Debug.WriteLine($"Formulário aberto: {childForm.GetType().Name}");
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "INÍCIO";
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;

            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Usuário.AbrirChamado(), sender);
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // Configurar a opacidade inicial como 0 (transparente)
            this.Opacity = 0;

            // Criar um temporizador para o evento Tick
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 12;
            fadeInTimer.Tick += (s, ev) =>
            {
                // Aumentar a opacidade do formulário
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.04; // Aumento de 0.05 por vez
                }
                else
                {
                    // Parar o Timer quando a opacidade atingir 1
                    fadeInTimer.Stop();
                    fadeInTimer.Dispose();
                }
            };
            fadeInTimer.Start();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Usuário.UsuarioConfig(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Hide(); // Esconde o Form1 antes de abrir TelaLogin
                TelaLogin telaLogin = new TelaLogin();
                telaLogin.ShowDialog(); // Abre a TelaLogin e espera ela ser fechada
                this.Close(); // Fecha o Form1 após o usuário sair da TelaLogin
            }
        }
    }
}
