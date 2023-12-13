namespace PD.Presentation.Forms.Configuracion
{
    partial class GestionarPatentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPatentes));
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            lbl_todas_patentes = new Label();
            cbx_patentes = new ComboBox();
            panel2 = new Panel();
            lbl_todas_familias = new Label();
            cbx_familias = new ComboBox();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 51);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 45);
            panel5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "PERMISOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_todas_patentes);
            panel1.Controls.Add(cbx_patentes);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 343);
            panel1.TabIndex = 8;
            // 
            // lbl_todas_patentes
            // 
            lbl_todas_patentes.AutoSize = true;
            lbl_todas_patentes.Location = new Point(29, 29);
            lbl_todas_patentes.Name = "lbl_todas_patentes";
            lbl_todas_patentes.Size = new Size(52, 15);
            lbl_todas_patentes.TabIndex = 1;
            lbl_todas_patentes.Text = "Patentes";
            // 
            // cbx_patentes
            // 
            cbx_patentes.FormattingEnabled = true;
            cbx_patentes.Location = new Point(29, 47);
            cbx_patentes.Name = "cbx_patentes";
            cbx_patentes.Size = new Size(263, 23);
            cbx_patentes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_todas_familias);
            panel2.Controls.Add(cbx_familias);
            panel2.Location = new Point(415, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 343);
            panel2.TabIndex = 9;
            // 
            // lbl_todas_familias
            // 
            lbl_todas_familias.AutoSize = true;
            lbl_todas_familias.Location = new Point(67, 29);
            lbl_todas_familias.Name = "lbl_todas_familias";
            lbl_todas_familias.Size = new Size(50, 15);
            lbl_todas_familias.TabIndex = 3;
            lbl_todas_familias.Text = "Familias";
            // 
            // cbx_familias
            // 
            cbx_familias.FormattingEnabled = true;
            cbx_familias.Location = new Point(67, 47);
            cbx_familias.Name = "cbx_familias";
            cbx_familias.Size = new Size(263, 23);
            cbx_familias.TabIndex = 2;
            // 
            // GestionarPatentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "GestionarPatentes";
            Text = "GestionarPatentes";
            Load += GestionarPatentes_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_todas_patentes;
        private ComboBox cbx_patentes;
        private Label lbl_todas_familias;
        private ComboBox cbx_familias;
    }
}