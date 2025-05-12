namespace SistemaDeChamados.ChatItens
{
    partial class BubbleMensagemEnviada
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblMensagem = new Label();
            lblNome = new Label();
            lblHora = new Label();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            guna2ContainerControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(15, 33);
            lblMensagem.Margin = new Padding(3, 2, 3, 2);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(230, 16);
            lblMensagem.TabIndex = 1;
            lblMensagem.Text = "Mensagem Enviada";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Bahnschrift SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(6, 7);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(121, 18);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome remetente";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(201, 50);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 16);
            lblHora.TabIndex = 2;
            lblHora.Text = "HH:mm";
            lblHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BackColor = Color.Transparent;
            guna2ContainerControl1.BorderRadius = 15;
            guna2ContainerControl1.Controls.Add(lblNome);
            guna2ContainerControl1.Controls.Add(lblHora);
            guna2ContainerControl1.Controls.Add(lblMensagem);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.FillColor = Color.SteelBlue;
            guna2ContainerControl1.Location = new Point(0, 0);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(267, 70);
            guna2ContainerControl1.TabIndex = 3;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // BubbleMensagemEnviada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ContainerControl1);
            Name = "BubbleMensagemEnviada";
            Size = new Size(267, 76);
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensagem;
        private Label lblNome;
        private Label lblHora;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
    }
}
