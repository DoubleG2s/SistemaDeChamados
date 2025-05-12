using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeChamados.ChatItens
{
    public partial class BubbleMensagemEnviada: UserControl
    {
        public BubbleMensagemEnviada()
        {
            InitializeComponent();
            this.Load += (s, e) => AjustarAltura();
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
            lblMensagem.MaximumSize = new Size(guna2ContainerControl1.Width - 30, 0); // margem segura
            lblMensagem.TextAlign = ContentAlignment.TopLeft;

            using (Graphics g = lblMensagem.CreateGraphics())
            {
                SizeF tamanho = g.MeasureString(lblMensagem.Text, lblMensagem.Font, lblMensagem.MaximumSize.Width);
                lblMensagem.Height = (int)Math.Ceiling(tamanho.Height);
            }

            lblHora.Top = lblMensagem.Bottom + 6;
            lblHora.Left = guna2ContainerControl1.Width - lblHora.PreferredWidth - 12;

            guna2ContainerControl1.Height = lblHora.Bottom + 10;
            this.Height = guna2ContainerControl1.Bottom + 5;
        }




    }
}
