namespace PD.Presentation.Forms.Documentos
{
    partial class GestionOrdenesCompra
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
            pnl_head = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            pnl_head.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_head
            // 
            pnl_head.BackColor = Color.White;
            pnl_head.Controls.Add(panel5);
            pnl_head.Controls.Add(label1);
            pnl_head.Location = new Point(12, 12);
            pnl_head.Name = "pnl_head";
            pnl_head.Size = new Size(776, 54);
            pnl_head.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.cargo;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 45);
            panel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 1;
            label1.Text = "ORDENES";
            // 
            // GestionOrdenesCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_head);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionOrdenesCompra";
            ShowIcon = false;
            pnl_head.ResumeLayout(false);
            pnl_head.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_head;
        private Panel panel5;
        private Label label1;
    }
}