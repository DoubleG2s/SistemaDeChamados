namespace SistemaDeChamados.Forms
{
    partial class FormPopupChat
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTituloChat = new Panel();
            btnFechar = new Button();
            lblNomeUsuario = new Label();
            pictureBox1 = new PictureBox();
            panelChat = new Panel();
            txtMensagem = new Guna.UI2.WinForms.Guna2TextBox();
            btnEnviar = new Button();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            flowlpMensagens = new FlowLayoutPanel();
            panelTituloChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChat.SuspendLayout();
            SuspendLayout();
            // 
            // panelTituloChat
            // 
            panelTituloChat.BackColor = Color.FromArgb(9, 156, 255);
            panelTituloChat.Controls.Add(btnFechar);
            panelTituloChat.Controls.Add(lblNomeUsuario);
            panelTituloChat.Controls.Add(pictureBox1);
            panelTituloChat.Cursor = Cursors.Hand;
            panelTituloChat.Dock = DockStyle.Top;
            panelTituloChat.Location = new Point(0, 0);
            panelTituloChat.Name = "panelTituloChat";
            panelTituloChat.Size = new Size(446, 139);
            panelTituloChat.TabIndex = 0;
            panelTituloChat.Click += panelTituloChat_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.close;
            btnFechar.Location = new Point(375, 6);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 57);
            btnFechar.TabIndex = 2;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Bahnschrift", 16F);
            lblNomeUsuario.Location = new Point(98, 75);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(150, 27);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Nome usuário";
            lblNomeUsuario.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(28, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChat
            // 
            panelChat.BackColor = Color.LightGray;
            panelChat.Controls.Add(txtMensagem);
            panelChat.Controls.Add(btnEnviar);
            panelChat.Dock = DockStyle.Bottom;
            panelChat.Location = new Point(0, 509);
            panelChat.Name = "panelChat";
            panelChat.Size = new Size(446, 92);
            panelChat.TabIndex = 0;
            // 
            // txtMensagem
            // 
            txtMensagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMensagem.BorderThickness = 2;
            txtMensagem.CustomizableEdges = customizableEdges1;
            txtMensagem.DefaultText = "";
            txtMensagem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMensagem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMensagem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMensagem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMensagem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMensagem.Font = new Font("Segoe UI", 9F);
            txtMensagem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMensagem.Location = new Point(6, 7);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.PlaceholderText = "Digite...";
            txtMensagem.SelectedText = "";
            txtMensagem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMensagem.Size = new Size(382, 74);
            txtMensagem.TabIndex = 2;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Image = Properties.Resources.sent;
            btnEnviar.Location = new Point(391, 29);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(52, 32);
            btnEnviar.TabIndex = 1;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 15;
            guna2ShadowForm1.TargetForm = this;
            // 
            // flowlpMensagens
            // 
            flowlpMensagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowlpMensagens.AutoScroll = true;
            flowlpMensagens.FlowDirection = FlowDirection.TopDown;
            flowlpMensagens.Location = new Point(0, 139);
            flowlpMensagens.Name = "flowlpMensagens";
            flowlpMensagens.Size = new Size(446, 370);
            flowlpMensagens.TabIndex = 1;
            flowlpMensagens.WrapContents = false;
            // 
            // FormPopupChat
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(446, 601);
            Controls.Add(flowlpMensagens);
            Controls.Add(panelChat);
            Controls.Add(panelTituloChat);
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPopupChat";
            Load += FormPopupChat_Load;
            panelTituloChat.ResumeLayout(false);
            panelTituloChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTituloChat;
        private Panel panelChat;
        private Button btnEnviar;
        private PictureBox pictureBox1;
        private Label lblNomeUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtMensagem;
        private Button btnFechar;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private FlowLayoutPanel flowlpMensagens;
    }
}