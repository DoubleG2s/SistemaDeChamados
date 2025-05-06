namespace SistemaDeChamados.Forms
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            txtPass = new TextBox();
            txtSenha = new Label();
            txtConfPass = new TextBox();
            txtConfSenha = new Label();
            checkMostrarSenha = new CheckBox();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            label3 = new Label();
            lblBackLogin = new Label();
            btnClose = new Button();
            txtNome = new TextBox();
            label5 = new Label();
            panelDragBar = new Panel();
            parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            pictureBox1 = new PictureBox();
            panelDragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 136, 228);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(613, 60);
            label1.Name = "label1";
            label1.Size = new Size(219, 27);
            label1.TabIndex = 0;
            label1.Text = "Vamos Registrar!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            label2.Location = new Point(613, 177);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 0;
            label2.Text = "Usuário";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(230, 231, 233);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Bahnschrift SemiLight", 12F);
            txtLogin.Location = new Point(613, 197);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(216, 20);
            txtLogin.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(230, 231, 233);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Bahnschrift SemiLight", 12F);
            txtPass.Location = new Point(613, 254);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.Size = new Size(216, 20);
            txtPass.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            txtSenha.Location = new Point(613, 234);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(48, 19);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "Senha";
            // 
            // txtConfPass
            // 
            txtConfPass.BackColor = Color.FromArgb(230, 231, 233);
            txtConfPass.BorderStyle = BorderStyle.None;
            txtConfPass.Font = new Font("Bahnschrift SemiLight", 12F);
            txtConfPass.Location = new Point(613, 318);
            txtConfPass.Name = "txtConfPass";
            txtConfPass.PasswordChar = '●';
            txtConfPass.Size = new Size(216, 20);
            txtConfPass.TabIndex = 3;
            txtConfPass.KeyDown += txtConfPass_KeyDown;
            // 
            // txtConfSenha
            // 
            txtConfSenha.AutoSize = true;
            txtConfSenha.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            txtConfSenha.Location = new Point(613, 296);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(116, 19);
            txtConfSenha.TabIndex = 0;
            txtConfSenha.Text = "Confirmar Senha";
            // 
            // checkMostrarSenha
            // 
            checkMostrarSenha.AutoSize = true;
            checkMostrarSenha.Cursor = Cursors.Hand;
            checkMostrarSenha.FlatAppearance.BorderSize = 0;
            checkMostrarSenha.FlatStyle = FlatStyle.Flat;
            checkMostrarSenha.Location = new Point(717, 352);
            checkMostrarSenha.Name = "checkMostrarSenha";
            checkMostrarSenha.Size = new Size(112, 21);
            checkMostrarSenha.TabIndex = 4;
            checkMostrarSenha.Text = "Mostrar senha";
            checkMostrarSenha.UseVisualStyleBackColor = true;
            checkMostrarSenha.CheckedChanged += checkMostrarSenha_CheckedChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(9, 156, 255);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(613, 402);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(216, 35);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Registrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.FromArgb(0, 136, 228);
            btnLimpar.Location = new Point(613, 443);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(216, 35);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            label3.Location = new Point(658, 481);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 10;
            label3.Text = "Já tem uma conta?";
            // 
            // lblBackLogin
            // 
            lblBackLogin.AutoSize = true;
            lblBackLogin.Cursor = Cursors.Hand;
            lblBackLogin.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            lblBackLogin.ForeColor = Color.FromArgb(0, 136, 228);
            lblBackLogin.Location = new Point(681, 505);
            lblBackLogin.Name = "lblBackLogin";
            lblBackLogin.Size = new Size(87, 19);
            lblBackLogin.TabIndex = 7;
            lblBackLogin.Text = "Fazer LOGIN";
            lblBackLogin.Click += lblBackLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.power_button1;
            btnClose.Location = new Point(842, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 32);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(230, 231, 233);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Bahnschrift SemiLight", 12F);
            txtNome.Location = new Point(613, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 20);
            txtNome.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            label5.Location = new Point(613, 124);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 0;
            label5.Text = "Nome e Sobrenome";
            // 
            // panelDragBar
            // 
            panelDragBar.Controls.Add(btnClose);
            panelDragBar.Dock = DockStyle.Top;
            panelDragBar.Location = new Point(0, 0);
            panelDragBar.Name = "panelDragBar";
            panelDragBar.Size = new Size(882, 40);
            panelDragBar.TabIndex = 28;
            panelDragBar.MouseDown += panelDragBar_MouseDown;
            // 
            // parrotFormEllipse1
            // 
            parrotFormEllipse1.CornerRadius = 30;
            parrotFormEllipse1.EffectedForm = this;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            guna2AnimateWindow1.Interval = 250;
            guna2AnimateWindow1.TargetForm = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.artificial_intelligence;
            pictureBox1.Location = new Point(38, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 544);
            Controls.Add(pictureBox1);
            Controls.Add(panelDragBar);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(lblBackLogin);
            Controls.Add(label3);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(checkMostrarSenha);
            Controls.Add(txtConfPass);
            Controls.Add(txtConfSenha);
            Controls.Add(txtPass);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            panelDragBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtPass;
        private Label txtSenha;
        private TextBox txtConfPass;
        private Label txtConfSenha;
        private CheckBox checkMostrarSenha;
        private Button btnCadastrar;
        private Button btnLimpar;
        private Label label3;
        private Label lblBackLogin;
        private Button btnClose;
        private TextBox txtNome;
        private Label label5;
        private Panel panelDragBar;
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private PictureBox pictureBox1;
    }
}