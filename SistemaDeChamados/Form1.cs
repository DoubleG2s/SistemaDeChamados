using SistemaDeChamados.Forms;
using System.Runtime.InteropServices;

namespace SistemaDeChamados
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            
            btnCloseChildForm.Visible = false;
            ThemeColor.SetDefaultTheme(); // Define a cor padrão
            ApplyTheme();                 // Aplica a cor nos elementos
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MinimumSize = new Size(800, 600);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //Methods
        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}

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

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormChamados(), sender);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRelatorio(), sender);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConfigura(), sender);
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

        private void btnSobre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSobre(), sender);
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

        private void ApplyTheme()
        {
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;

            // DEIXA o panelLogo neutro até clicar em botão
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);

            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Estilo inativo
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }




        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panelDesktop.AutoScroll = true;  // Habilita a rolagem automática
            //panelDesktop.HorizontalScroll.Enabled = true; // Ativa a barra de rolagem horizontal
            //panelDesktop.HorizontalScroll.Visible = true; // Exibe a barra de rolagem horizontal
            //panelDesktop.AutoScrollMinSize = new Size(864, panelDesktop.Height); // Define um tamanho mínimo para a rolagem
        }
    }
}
