using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeChamados.ChatItens
{
    public partial class BubbleMensagemRecebida : UserControl
    {
        public BubbleMensagemRecebida()
        {
            InitializeComponent();
        }

        public string Remetente
        {
            get => lblNome.Text;
            set => lblNome.Text = value;
        }

        public string Mensagem
        {
            get => lblMensagem.Text;
            set
            {
                lblMensagem.Text = value;
                AjustarAltura();
            }
        }

        public string Hora
        {
            get => lblHora.Text;
            set => lblHora.Text = value;
        }

        private void AjustarAltura()
        {
            lblMensagem.AutoSize = false;
            lblMensagem.MaximumSize = new Size(guna2ContainerControl1.Width - 30, 0);
            lblMensagem.TextAlign = ContentAlignment.TopLeft;

            using (Graphics g = lblMensagem.CreateGraphics())
            {
                SizeF tamanho = g.MeasureString(lblMensagem.Text, lblMensagem.Font, lblMensagem.MaximumSize.Width);
                lblMensagem.Height = (int)Math.Ceiling(tamanho.Height) + 2; // margem de segurança
            }

            // Garante que a hora será posicionada depois do layout estar calculado
            this.Layout += (s, e) =>
            {
                lblHora.Top = lblMensagem.Bottom + 6;
                lblHora.Left = 12;

                guna2ContainerControl1.Height = lblHora.Bottom + 10;
                this.Height = guna2ContainerControl1.Bottom + 5;
            };

            this.PerformLayout(); // força o layout para aplicar o cálculo
        }

    }
}
