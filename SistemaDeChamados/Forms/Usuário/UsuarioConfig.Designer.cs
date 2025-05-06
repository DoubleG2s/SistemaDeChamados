namespace SistemaDeChamados.Forms.Usuário
{
    partial class UsuarioConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            separator4 = new ReaLTaiizor.Controls.Separator();
            separator3 = new ReaLTaiizor.Controls.Separator();
            separator2 = new ReaLTaiizor.Controls.Separator();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblAlterarSenha = new Label();
            panelDesktop = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(51, 51, 76);
            panelSidebar.Controls.Add(separator4);
            panelSidebar.Controls.Add(separator3);
            panelSidebar.Controls.Add(separator2);
            panelSidebar.Controls.Add(separator1);
            panelSidebar.Controls.Add(lblAlterarSenha);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(202, 450);
            panelSidebar.TabIndex = 3;
            // 
            // separator4
            // 
            separator4.LineColor = Color.Black;
            separator4.Location = new Point(12, 215);
            separator4.Name = "separator4";
            separator4.Size = new Size(167, 10);
            separator4.TabIndex = 5;
            separator4.Text = "separator4";
            // 
            // separator3
            // 
            separator3.LineColor = Color.Black;
            separator3.Location = new Point(12, 162);
            separator3.Name = "separator3";
            separator3.Size = new Size(167, 10);
            separator3.TabIndex = 4;
            separator3.Text = "separator3";
            // 
            // separator2
            // 
            separator2.LineColor = Color.Black;
            separator2.Location = new Point(12, 113);
            separator2.Name = "separator2";
            separator2.Size = new Size(167, 10);
            separator2.TabIndex = 3;
            separator2.Text = "separator2";
            // 
            // separator1
            // 
            separator1.LineColor = Color.Black;
            separator1.Location = new Point(12, 63);
            separator1.Name = "separator1";
            separator1.Size = new Size(167, 10);
            separator1.TabIndex = 2;
            separator1.Text = "separator1";
            // 
            // lblAlterarSenha
            // 
            lblAlterarSenha.AutoSize = true;
            lblAlterarSenha.Cursor = Cursors.Hand;
            lblAlterarSenha.FlatStyle = FlatStyle.Flat;
            lblAlterarSenha.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlterarSenha.ForeColor = Color.White;
            lblAlterarSenha.Image = Properties.Resources.padlock1;
            lblAlterarSenha.ImageAlign = ContentAlignment.MiddleLeft;
            lblAlterarSenha.Location = new Point(12, 41);
            lblAlterarSenha.Name = "lblAlterarSenha";
            lblAlterarSenha.Size = new Size(139, 19);
            lblAlterarSenha.TabIndex = 0;
            lblAlterarSenha.Text = "       Alterar Senha";
            lblAlterarSenha.Click += lblAlterarSenha_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(202, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(598, 450);
            panelDesktop.TabIndex = 4;
            // 
            // UsuarioConfig
            // 
            AutoScaleDimensions = new SizeF(5F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktop);
            Controls.Add(panelSidebar);
            Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "UsuarioConfig";
            Text = "Configurações";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private ReaLTaiizor.Controls.Separator separator4;
        private ReaLTaiizor.Controls.Separator separator3;
        private ReaLTaiizor.Controls.Separator separator2;
        private ReaLTaiizor.Controls.Separator separator1;
        private Label lblAlterarSenha;
        private Panel panelDesktop;
    }
}