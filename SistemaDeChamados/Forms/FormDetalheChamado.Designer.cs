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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelTitleBar = new Panel();
            btnMinimizar = new Button();
            btnFechar = new Button();
            labelId = new Label();
            labelTitulo = new Label();
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
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnFechar);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1015, 59);
            panelTitleBar.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 2;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(936, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 2;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(980, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(23, 23);
            btnFechar.TabIndex = 1;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.ForeColor = Color.FromArgb(192, 0, 0);
            labelId.Location = new Point(12, 62);
            labelId.Name = "labelId";
            labelId.Size = new Size(23, 16);
            labelId.TabIndex = 1;
            labelId.Text = "ID:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Bahnschrift", 16F);
            labelTitulo.Location = new Point(12, 136);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(67, 27);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "label1";
            // 
            // FormDetalheChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 656);
            Controls.Add(labelTitulo);
            Controls.Add(labelId);
            Controls.Add(panelTitleBar);
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
    }
}