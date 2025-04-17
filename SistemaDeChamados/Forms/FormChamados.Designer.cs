namespace SistemaDeChamados.Forms
{
    partial class FormChamados
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
            flowLayoutPanelChamados = new FlowLayoutPanel();
            lblStatus1 = new Label();
            llblStatus2 = new Label();
            lblStatus3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            spaceSeparatorVertical1 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorVertical2 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            SuspendLayout();
            // 
            // flowLayoutPanelChamados
            // 
            flowLayoutPanelChamados.Anchor = AnchorStyles.Top;
            flowLayoutPanelChamados.AutoScroll = true;
            flowLayoutPanelChamados.BackColor = Color.White;
            flowLayoutPanelChamados.Location = new Point(12, 221);
            flowLayoutPanelChamados.Name = "flowLayoutPanelChamados";
            flowLayoutPanelChamados.Padding = new Padding(10);
            flowLayoutPanelChamados.Size = new Size(1087, 396);
            flowLayoutPanelChamados.TabIndex = 5;
            // 
            // lblStatus1
            // 
            lblStatus1.Anchor = AnchorStyles.Top;
            lblStatus1.AutoSize = true;
            lblStatus1.Font = new Font("Bahnschrift", 24F);
            lblStatus1.Location = new Point(121, 136);
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(35, 39);
            lblStatus1.TabIndex = 6;
            lblStatus1.Text = "0";
            // 
            // llblStatus2
            // 
            llblStatus2.Anchor = AnchorStyles.Top;
            llblStatus2.AutoSize = true;
            llblStatus2.Font = new Font("Bahnschrift", 24F);
            llblStatus2.Location = new Point(544, 136);
            llblStatus2.Name = "llblStatus2";
            llblStatus2.Size = new Size(35, 39);
            llblStatus2.TabIndex = 7;
            llblStatus2.Text = "0";
            // 
            // lblStatus3
            // 
            lblStatus3.Anchor = AnchorStyles.Top;
            lblStatus3.AutoSize = true;
            lblStatus3.Font = new Font("Bahnschrift", 24F);
            lblStatus3.Location = new Point(958, 136);
            lblStatus3.Name = "lblStatus3";
            lblStatus3.Size = new Size(35, 39);
            lblStatus3.TabIndex = 8;
            lblStatus3.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Bahnschrift", 20F);
            label1.Location = new Point(82, 71);
            label1.Name = "label1";
            label1.Size = new Size(111, 33);
            label1.TabIndex = 9;
            label1.Text = "Abertos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Salmon;
            label2.Font = new Font("Bahnschrift", 20F);
            label2.Location = new Point(494, 71);
            label2.Name = "label2";
            label2.Size = new Size(126, 33);
            label2.TabIndex = 10;
            label2.Text = "Urgentes";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Bahnschrift", 20F);
            label3.Location = new Point(904, 71);
            label3.Name = "label3";
            label3.Size = new Size(123, 33);
            label3.TabIndex = 11;
            label3.Text = "Vencidos";
            // 
            // spaceSeparatorVertical1
            // 
            spaceSeparatorVertical1.Anchor = AnchorStyles.Top;
            spaceSeparatorVertical1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical1.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical1.Image = null;
            spaceSeparatorVertical1.Location = new Point(338, 65);
            spaceSeparatorVertical1.Name = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.NoRounding = false;
            spaceSeparatorVertical1.Size = new Size(4, 150);
            spaceSeparatorVertical1.TabIndex = 13;
            spaceSeparatorVertical1.Text = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.Transparent = false;
            // 
            // spaceSeparatorVertical2
            // 
            spaceSeparatorVertical2.Anchor = AnchorStyles.Top;
            spaceSeparatorVertical2.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical2.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical2.Image = null;
            spaceSeparatorVertical2.Location = new Point(796, 65);
            spaceSeparatorVertical2.Name = "spaceSeparatorVertical2";
            spaceSeparatorVertical2.NoRounding = false;
            spaceSeparatorVertical2.Size = new Size(4, 150);
            spaceSeparatorVertical2.TabIndex = 14;
            spaceSeparatorVertical2.Text = "spaceSeparatorVertical2";
            spaceSeparatorVertical2.Transparent = false;
            // 
            // FormChamados
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1115, 672);
            Controls.Add(spaceSeparatorVertical2);
            Controls.Add(spaceSeparatorVertical1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStatus3);
            Controls.Add(llblStatus2);
            Controls.Add(lblStatus1);
            Controls.Add(flowLayoutPanelChamados);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChamados";
            Text = "QUADRO DE CHAMADOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelChamados;
        private Label lblStatus1;
        private Label llblStatus2;
        private Label lblStatus3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical1;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical2;
    }
}