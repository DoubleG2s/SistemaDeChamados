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
            panelTituloChat = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelChat = new Panel();
            btnEnviar = new Button();
            txtMensagem = new TextBox();
            flowlpMensagens = new FlowLayoutPanel();
            panelTituloChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChat.SuspendLayout();
            SuspendLayout();
            // 
            // panelTituloChat
            // 
            panelTituloChat.BackColor = Color.FromArgb(9, 156, 255);
            panelTituloChat.Controls.Add(pictureBox1);
            panelTituloChat.Controls.Add(label1);
            panelTituloChat.Cursor = Cursors.Hand;
            panelTituloChat.Dock = DockStyle.Top;
            panelTituloChat.Location = new Point(0, 0);
            panelTituloChat.Name = "panelTituloChat";
            panelTituloChat.Size = new Size(300, 57);
            panelTituloChat.TabIndex = 0;
            panelTituloChat.Click += panelTituloChat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.MSG;
            pictureBox1.Location = new Point(233, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 39);
            label1.TabIndex = 0;
            label1.Text = "MENSAGENS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelChat
            // 
            panelChat.BackColor = Color.LightGray;
            panelChat.Controls.Add(btnEnviar);
            panelChat.Controls.Add(txtMensagem);
            panelChat.Dock = DockStyle.Bottom;
            panelChat.Location = new Point(0, 340);
            panelChat.Name = "panelChat";
            panelChat.Size = new Size(300, 60);
            panelChat.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Image = Properties.Resources.sent;
            btnEnviar.Location = new Point(245, 25);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(52, 32);
            btnEnviar.TabIndex = 1;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Dock = DockStyle.Fill;
            txtMensagem.Font = new Font("Bahnschrift", 10F);
            txtMensagem.Location = new Point(0, 0);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.PlaceholderText = "Digite...";
            txtMensagem.Size = new Size(300, 24);
            txtMensagem.TabIndex = 0;
            // 
            // flowlpMensagens
            // 
            flowlpMensagens.AutoScroll = true;
            flowlpMensagens.Dock = DockStyle.Fill;
            flowlpMensagens.FlowDirection = FlowDirection.TopDown;
            flowlpMensagens.Location = new Point(0, 57);
            flowlpMensagens.Name = "flowlpMensagens";
            flowlpMensagens.Size = new Size(300, 283);
            flowlpMensagens.TabIndex = 1;
            flowlpMensagens.WrapContents = false;
            // 
            // FormPopupChat
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(flowlpMensagens);
            Controls.Add(panelChat);
            Controls.Add(panelTituloChat);
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPopupChat";
            Text = "FormPopupChat";
            Load += FormPopupChat_Load;
            panelTituloChat.ResumeLayout(false);
            panelTituloChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChat.ResumeLayout(false);
            panelChat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTituloChat;
        private Panel panelChat;
        private Button btnEnviar;
        private TextBox txtMensagem;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowlpMensagens;
    }
}