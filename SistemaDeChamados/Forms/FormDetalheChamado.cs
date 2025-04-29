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
            // Reflete as propriedades do objeto
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
            }
        }
    }
}
