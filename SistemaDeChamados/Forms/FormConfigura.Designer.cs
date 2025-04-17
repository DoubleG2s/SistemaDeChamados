namespace SistemaDeChamados.Forms
{
    partial class FormConfigura
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigura));
            usuarioRepositoryBindingSource = new BindingSource(components);
            dgvUsuarios = new DataGridView();
            panelDesktop = new Panel();
            panelSidebar = new Panel();
            separator4 = new ReaLTaiizor.Controls.Separator();
            separator3 = new ReaLTaiizor.Controls.Separator();
            separator2 = new ReaLTaiizor.Controls.Separator();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblViewTable = new Label();
            lblAlterarSenha = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)usuarioRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelDesktop.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // usuarioRepositoryBindingSource
            // 
            usuarioRepositoryBindingSource.DataSource = typeof(Data.UsuarioRepository);
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top;
            dgvUsuarios.BackgroundColor = SystemColors.ActiveBorder;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(208, 81);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(580, 256);
            dgvUsuarios.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(dgvUsuarios);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(800, 450);
            panelDesktop.TabIndex = 1;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(51, 51, 76);
            panelSidebar.Controls.Add(separator4);
            panelSidebar.Controls.Add(separator3);
            panelSidebar.Controls.Add(separator2);
            panelSidebar.Controls.Add(separator1);
            panelSidebar.Controls.Add(lblViewTable);
            panelSidebar.Controls.Add(lblAlterarSenha);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(202, 450);
            panelSidebar.TabIndex = 2;
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
            // lblViewTable
            // 
            lblViewTable.AutoSize = true;
            lblViewTable.Cursor = Cursors.Hand;
            lblViewTable.FlatStyle = FlatStyle.Flat;
            lblViewTable.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViewTable.ForeColor = Color.White;
            lblViewTable.Image = (Image)resources.GetObject("lblViewTable.Image");
            lblViewTable.ImageAlign = ContentAlignment.MiddleLeft;
            lblViewTable.Location = new Point(12, 72);
            lblViewTable.Name = "lblViewTable";
            lblViewTable.Size = new Size(161, 38);
            lblViewTable.TabIndex = 1;
            lblViewTable.Text = "       Visualizar Tabela\r\n       de usuários";
            lblViewTable.Click += lblViewTable_Click;
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
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = dgvUsuarios;
            // 
            // FormConfigura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelSidebar);
            Controls.Add(panelDesktop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfigura";
            Text = "CONFIGURAÇÕES";
            Load += FormConfigura_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelDesktop.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource usuarioRepositoryBindingSource;
        private DataGridView dgvUsuarios;
        private Panel panelDesktop;
        private Panel panelSidebar;
        private Label lblAlterarSenha;
        private Label lblViewTable;
        private ReaLTaiizor.Controls.Separator separator4;
        private ReaLTaiizor.Controls.Separator separator3;
        private ReaLTaiizor.Controls.Separator separator2;
        private ReaLTaiizor.Controls.Separator separator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}