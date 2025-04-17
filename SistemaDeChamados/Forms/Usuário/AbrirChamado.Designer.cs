namespace SistemaDeChamados.Forms.Usuário
{
    partial class AbrirChamado
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelAbrirChamado = new Guna.UI2.WinForms.Guna2Panel();
            btnAbrirChamado = new Button();
            txtTituloChamado = new Guna.UI2.WinForms.Guna2TextBox();
            txtDescri = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelAbrirChamado.SuspendLayout();
            SuspendLayout();
            // 
            // panelAbrirChamado
            // 
            panelAbrirChamado.Anchor = AnchorStyles.Top;
            panelAbrirChamado.BackColor = Color.White;
            panelAbrirChamado.BorderRadius = 15;
            panelAbrirChamado.Controls.Add(btnAbrirChamado);
            panelAbrirChamado.Controls.Add(txtTituloChamado);
            panelAbrirChamado.Controls.Add(txtDescri);
            panelAbrirChamado.CustomizableEdges = customizableEdges5;
            panelAbrirChamado.Location = new Point(103, 47);
            panelAbrirChamado.Name = "panelAbrirChamado";
            panelAbrirChamado.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelAbrirChamado.Size = new Size(822, 381);
            panelAbrirChamado.TabIndex = 0;
            // 
            // btnAbrirChamado
            // 
            btnAbrirChamado.BackColor = Color.FromArgb(128, 255, 128);
            btnAbrirChamado.FlatAppearance.BorderSize = 0;
            btnAbrirChamado.FlatStyle = FlatStyle.Flat;
            btnAbrirChamado.Location = new Point(678, 282);
            btnAbrirChamado.Name = "btnAbrirChamado";
            btnAbrirChamado.Size = new Size(83, 42);
            btnAbrirChamado.TabIndex = 3;
            btnAbrirChamado.Text = "Abrir Chamado";
            btnAbrirChamado.UseVisualStyleBackColor = false;
            btnAbrirChamado.Click += btnAbrirChamado_Click;
            // 
            // txtTituloChamado
            // 
            txtTituloChamado.BackColor = Color.White;
            txtTituloChamado.BorderRadius = 15;
            txtTituloChamado.BorderThickness = 0;
            txtTituloChamado.CustomizableEdges = customizableEdges1;
            txtTituloChamado.DefaultText = "";
            txtTituloChamado.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTituloChamado.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTituloChamado.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTituloChamado.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTituloChamado.FillColor = Color.Linen;
            txtTituloChamado.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTituloChamado.Font = new Font("Segoe UI", 9F);
            txtTituloChamado.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTituloChamado.Location = new Point(194, 74);
            txtTituloChamado.Name = "txtTituloChamado";
            txtTituloChamado.PlaceholderText = "Assunto";
            txtTituloChamado.SelectedText = "";
            txtTituloChamado.ShadowDecoration.BorderRadius = 9;
            txtTituloChamado.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTituloChamado.Size = new Size(448, 44);
            txtTituloChamado.TabIndex = 1;
            // 
            // txtDescri
            // 
            txtDescri.BackColor = Color.White;
            txtDescri.BorderRadius = 15;
            txtDescri.BorderThickness = 0;
            txtDescri.CustomizableEdges = customizableEdges3;
            txtDescri.DefaultText = "";
            txtDescri.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescri.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescri.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescri.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescri.FillColor = Color.Linen;
            txtDescri.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescri.Font = new Font("Segoe UI", 9F);
            txtDescri.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescri.Location = new Point(194, 224);
            txtDescri.Multiline = true;
            txtDescri.Name = "txtDescri";
            txtDescri.PlaceholderText = "Descreva seu chamado...";
            txtDescri.SelectedText = "";
            txtDescri.ShadowDecoration.BorderRadius = 9;
            txtDescri.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDescri.Size = new Size(448, 100);
            txtDescri.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = panelAbrirChamado;
            // 
            // AbrirChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 480);
            Controls.Add(panelAbrirChamado);
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AbrirChamado";
            Text = "ABRIR CHAMADO";
            panelAbrirChamado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelAbrirChamado;
        private Guna.UI2.WinForms.Guna2TextBox txtDescri;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button btnAbrirChamado;
        private Guna.UI2.WinForms.Guna2TextBox txtTituloChamado;
    }
}