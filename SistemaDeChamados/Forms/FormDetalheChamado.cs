using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SistemaDeChamados
{
    public partial class FormDetalheChamado : Form
    {


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
            this.Text = "Detalhes do Chamado";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(800, 600);
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            PreencherLabels(dadosChamado);
        }

        private void PreencherLabels(object dadosChamado)
        {
            var props = dadosChamado.GetType().GetProperties();

            foreach (var prop in props)
            {
                if (prop.Name.ToLower() == "id" && labelId != null)
                {
                    labelId.Text = "#" + prop.GetValue(dadosChamado)?.ToString();
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
    }
}
