using SistemaDeChamados.Forms.OptionsConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaDeChamados.Forms.Usuário
{
    public partial class UsuarioConfig : Form
    {

        private Form activeForm;
        public UsuarioConfig()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void lblAlterarSenha_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formAlteraSenha(), sender);
        }
    }
}
