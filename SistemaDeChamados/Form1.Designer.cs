namespace SistemaDeChamados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnSobre = new Button();
            btnLogout = new Button();
            btnConfig = new Button();
            btnRelatorio = new Button();
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
            pictureBox1 = new PictureBox();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
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
            panelMenu.Controls.Add(btnRelatorio);
            panelMenu.Controls.Add(btnChamados);
            panelMenu.Controls.Add(panelLogo);
            guna2Transition1.SetDecoration(panelMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 581);
            panelMenu.TabIndex = 0;
            // 
            // btnSobre
            // 
            btnSobre.Cursor = Cursors.Hand;
            guna2Transition1.SetDecoration(btnSobre, Guna.UI2.AnimatorNS.DecorationType.None);
            btnSobre.Dock = DockStyle.Top;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.ForeColor = Color.Gainsboro;
            btnSobre.Image = (Image)resources.GetObject("btnSobre.Image");
            btnSobre.ImageAlign = ContentAlignment.MiddleLeft;
            btnSobre.Location = new Point(0, 320);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(220, 60);
            btnSobre.TabIndex = 5;
            btnSobre.Text = "    Sobre";
            btnSobre.TextAlign = ContentAlignment.MiddleLeft;
            btnSobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSobre.UseVisualStyleBackColor = true;
            btnSobre.Click += btnSobre_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            guna2Transition1.SetDecoration(btnLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Gainsboro;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 260);
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
            guna2Transition1.SetDecoration(btnConfig, Guna.UI2.AnimatorNS.DecorationType.None);
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.ForeColor = Color.Gainsboro;
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(0, 200);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(220, 60);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "    Configurações";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Cursor = Cursors.Hand;
            guna2Transition1.SetDecoration(btnRelatorio, Guna.UI2.AnimatorNS.DecorationType.None);
            btnRelatorio.Dock = DockStyle.Top;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.ForeColor = Color.Gainsboro;
            btnRelatorio.Image = (Image)resources.GetObject("btnRelatorio.Image");
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.Location = new Point(0, 140);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(220, 60);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "    Relatório";
            btnRelatorio.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnChamados
            // 
            btnChamados.Cursor = Cursors.Hand;
            guna2Transition1.SetDecoration(btnChamados, Guna.UI2.AnimatorNS.DecorationType.None);
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
            btnChamados.Text = "    Quadro de Chamados";
            btnChamados.TextAlign = ContentAlignment.MiddleLeft;
            btnChamados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChamados.UseVisualStyleBackColor = true;
            btnChamados.Click += btnChamados_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            guna2Transition1.SetDecoration(panelLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Cursor = Cursors.NoMove2D;
            guna2Transition1.SetDecoration(panelTitleBar, Guna.UI2.AnimatorNS.DecorationType.None);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(975, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            guna2Transition1.SetDecoration(btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Humnst777 BT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(874, 3);
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
            guna2Transition1.SetDecoration(btnMaximize, Guna.UI2.AnimatorNS.DecorationType.None);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Humnst777 BT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(908, 3);
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
            guna2Transition1.SetDecoration(btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Humnst777 BT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(942, 3);
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
            guna2Transition1.SetDecoration(btnCloseChildForm, Guna.UI2.AnimatorNS.DecorationType.None);
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
            guna2Transition1.SetDecoration(lblTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            lblTitle.Font = new Font("Humanst521 BT", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(428, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(80, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INÍCIO";
            // 
            // panelDesktop
            // 
            panelDesktop.AutoScroll = true;
            panelDesktop.Controls.Add(pictureBox1);
            guna2Transition1.SetDecoration(panelDesktop, Guna.UI2.AnimatorNS.DecorationType.None);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(975, 501);
            panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            guna2Transition1.SetDecoration(pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 581);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            MinimumSize = new Size(950, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
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
        private Panel panelLogo;
        private Button btnChamados;
        private Button btnSobre;
        private Button btnLogout;
        private Button btnConfig;
        private Button btnRelatorio;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktop;
        private Button btnCloseChildForm;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}
