namespace SistemaDeChamados.Forms
{
    partial class TelaLogin
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
            lblRegistro = new Label();
            label3 = new Label();
            button2 = new Button();
            btnLogin = new Button();
            checkMostrarSenha = new CheckBox();
            txtPass = new TextBox();
            txtSenha = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelDragBar = new Panel();
            btnClose = new Button();
            timer = new System.Windows.Forms.Timer(components);
            parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            pictureBox1 = new PictureBox();
            panelDragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Cursor = Cursors.Hand;
            lblRegistro.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            lblRegistro.ForeColor = Color.FromArgb(116, 86, 174);
            lblRegistro.Location = new Point(677, 462);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(89, 19);
            lblRegistro.TabIndex = 23;
            lblRegistro.Text = "Registrar-se";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            label3.Location = new Point(654, 434);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 22;
            label3.Text = "Não tenho uma conta";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(613, 377);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 21;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(116, 86, 174);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(613, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 35);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkMostrarSenha
            // 
            checkMostrarSenha.AutoSize = true;
            checkMostrarSenha.Cursor = Cursors.Hand;
            checkMostrarSenha.FlatAppearance.BorderSize = 0;
            checkMostrarSenha.FlatStyle = FlatStyle.Flat;
            checkMostrarSenha.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            checkMostrarSenha.Location = new Point(717, 253);
            checkMostrarSenha.Name = "checkMostrarSenha";
            checkMostrarSenha.Size = new Size(117, 23);
            checkMostrarSenha.TabIndex = 19;
            checkMostrarSenha.Text = "Mostrar senha";
            checkMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(230, 231, 233);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Bahnschrift SemiLight", 12F);
            txtPass.Location = new Point(613, 219);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(216, 28);
            txtPass.TabIndex = 16;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Font = new Font("Bahnschrift SemiLight SemiConde", 12F);
            txtSenha.Location = new Point(613, 199);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(48, 19);
            txtSenha.TabIndex = 15;
            txtSenha.Text = "Senha";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(613, 162);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(613, 142);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(613, 103);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDragBar
            // 
            panelDragBar.Controls.Add(btnClose);
            panelDragBar.Dock = DockStyle.Top;
            panelDragBar.Location = new Point(0, 0);
            panelDragBar.Name = "panelDragBar";
            panelDragBar.Size = new Size(882, 40);
            panelDragBar.TabIndex = 26;
            panelDragBar.MouseDown += panelDragBar_MouseDown;
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
            btnClose.TabIndex = 24;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // timer
            // 
            timer.Interval = 10;
            // 
            // parrotFormEllipse1
            // 
            parrotFormEllipse1.CornerRadius = 30;
            parrotFormEllipse1.EffectedForm = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.artificial_intelligence;
            pictureBox1.Location = new Point(44, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(882, 554);
            Controls.Add(pictureBox1);
            Controls.Add(panelDragBar);
            Controls.Add(lblRegistro);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(checkMostrarSenha);
            Controls.Add(txtPass);
            Controls.Add(txtSenha);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTheme1";
            TransparencyKey = Color.Fuchsia;
            panelDragBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Label label3;
        private Button button2;
        private Button btnLogin;
        private CheckBox checkMostrarSenha;
        private TextBox txtPass;
        private Label txtSenha;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Panel panelDragBar;
        private Button btnClose;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private PictureBox pictureBox1;
    }
}