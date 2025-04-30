namespace SistemaDeChamados
{
    partial class FormDetalheChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalheChamado));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelTitleBar = new Panel();
            btnMinimizar = new Button();
            btnFechar = new Button();
            labelId = new Label();
            labelTitulo = new Label();
            labelDescri = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelDataRegistro = new Label();
            label4 = new Label();
            labelUsuario = new Label();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationInterval = 120;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Silver;
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnFechar);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1120, 59);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = Properties.Resources.minimize;
            btnMinimizar.Location = new Point(1041, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.exit;
            btnFechar.Location = new Point(1085, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(23, 23);
            btnFechar.TabIndex = 1;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.Top;
            labelId.AutoSize = true;
            labelId.ForeColor = Color.FromArgb(192, 0, 0);
            labelId.Location = new Point(12, 68);
            labelId.Name = "labelId";
            labelId.Size = new Size(23, 16);
            labelId.TabIndex = 1;
            labelId.Text = "ID:";
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Bahnschrift", 14F);
            labelTitulo.Location = new Point(174, 177);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(166, 23);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Título do Chamado";
            // 
            // labelDescri
            // 
            labelDescri.Anchor = AnchorStyles.Top;
            labelDescri.AutoSize = true;
            labelDescri.Location = new Point(91, 250);
            labelDescri.Name = "labelDescri";
            labelDescri.Size = new Size(440, 112);
            labelDescri.TabIndex = 3;
            labelDescri.Text = resources.GetString("labelDescri.Text");
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15F);
            label1.Location = new Point(91, 217);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 4;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 15F);
            label2.Location = new Point(91, 176);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 5;
            label2.Text = "Título:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 15F);
            label3.Location = new Point(91, 422);
            label3.Name = "label3";
            label3.Size = new Size(142, 24);
            label3.TabIndex = 6;
            label3.Text = "Data abertura:";
            // 
            // labelDataRegistro
            // 
            labelDataRegistro.Anchor = AnchorStyles.Top;
            labelDataRegistro.AutoSize = true;
            labelDataRegistro.Font = new Font("Bahnschrift", 14F);
            labelDataRegistro.ForeColor = Color.Teal;
            labelDataRegistro.Location = new Point(248, 423);
            labelDataRegistro.Name = "labelDataRegistro";
            labelDataRegistro.Size = new Size(163, 23);
            labelDataRegistro.TabIndex = 7;
            labelDataRegistro.Text = "dd/mm/aaaa 00:00";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 15F);
            label4.Location = new Point(790, 67);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 8;
            label4.Text = "Usuário:";
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Bahnschrift", 14F);
            labelUsuario.Location = new Point(881, 68);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(161, 23);
            labelUsuario.TabIndex = 9;
            labelUsuario.Text = "Nome Sobrenome";
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(91, 210);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(560, 4);
            spaceSeparatorHorizontal1.TabIndex = 10;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // FormDetalheChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 568);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(labelUsuario);
            Controls.Add(label4);
            Controls.Add(panelTitleBar);
            Controls.Add(labelDescri);
            Controls.Add(labelDataRegistro);
            Controls.Add(labelId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTitulo);
            Controls.Add(label3);
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetalheChamado";
            Text = "Detalhes";
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panelTitleBar;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label labelTitulo;
        private Label labelId;
        private Label label2;
        private Label label1;
        private Label labelDescri;
        private Label labelUsuario;
        private Label label4;
        private Label labelDataRegistro;
        private Label label3;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
    }
}