namespace SistemaDeChamados
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            panelMenu = new Panel();
            btnSobre = new Button();
            btnLogout = new Button();
            btnConfig = new Button();
            btnChamados = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            fadeInTimer = new System.Windows.Forms.Timer(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnSobre);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Controls.Add(btnChamados);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 581);
            panelMenu.TabIndex = 1;
            // 
            // btnSobre
            // 
            btnSobre.Cursor = Cursors.Hand;
            btnSobre.Dock = DockStyle.Top;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.ForeColor = Color.Gainsboro;
            btnSobre.Image = (Image)resources.GetObject("btnSobre.Image");
            btnSobre.ImageAlign = ContentAlignment.MiddleLeft;
            btnSobre.Location = new Point(0, 260);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(220, 60);
            btnSobre.TabIndex = 5;
            btnSobre.Text = "    Sobre";
            btnSobre.TextAlign = ContentAlignment.MiddleLeft;
            btnSobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Gainsboro;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 200);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "    Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnConfig
            // 
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.ForeColor = Color.Gainsboro;
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(0, 140);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(220, 60);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "    Configurações";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnChamados
            // 
            btnChamados.Cursor = Cursors.Hand;
            btnChamados.Dock = DockStyle.Top;
            btnChamados.FlatAppearance.BorderSize = 0;
            btnChamados.FlatStyle = FlatStyle.Flat;
            btnChamados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChamados.ForeColor = Color.Gainsboro;
            btnChamados.Image = Properties.Resources.menu;
            btnChamados.ImageAlign = ContentAlignment.MiddleLeft;
            btnChamados.Location = new Point(0, 80);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(220, 60);
            btnChamados.TabIndex = 1;
            btnChamados.Text = "    Chamados";
            btnChamados.TextAlign = ContentAlignment.MiddleLeft;
            btnChamados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChamados.UseVisualStyleBackColor = true;
            btnChamados.Click += btnChamados_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE CHAMADOS";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(9, 156, 255);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1150, 80);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Humnst777 BT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1045, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Humnst777 BT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1081, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Humnst777 BT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1117, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Cursor = Cursors.Hand;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Humanst521 BT", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(520, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(80, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INÍCIO";
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1150, 501);
            panelDesktop.TabIndex = 3;
            // 
            // fadeInTimer
            // 
            fadeInTimer.Interval = 10;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 25;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Black_and_White_Modern_Streetwear_Logo;
            pictureBox1.Location = new Point(334, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 99;
            guna2Elipse1.TargetControl = pictureBox1;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 581);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 500);
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnSobre;
        private Button btnLogout;
        private Button btnConfig;
        private Button btnChamados;
        private Panel panelLogo;
        private Label label1;
        private Panel panelTitleBar;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnCloseChildForm;
        private Label lblTitle;
        private Panel panelDesktop;
        private System.Windows.Forms.Timer fadeInTimer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}