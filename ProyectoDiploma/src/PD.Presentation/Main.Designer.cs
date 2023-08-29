namespace PD.Presentation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_articulos = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_gestionarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_articulos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_articulos
            // 
            this.tsb_articulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_gestionarArticulos});
            this.tsb_articulos.Image = ((System.Drawing.Image)(resources.GetObject("tsb_articulos.Image")));
            this.tsb_articulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_articulos.Name = "tsb_articulos";
            this.tsb_articulos.Size = new System.Drawing.Size(67, 22);
            this.tsb_articulos.Text = "Articulos";
            // 
            // btn_gestionarArticulos
            // 
            this.btn_gestionarArticulos.Name = "btn_gestionarArticulos";
            this.btn_gestionarArticulos.Size = new System.Drawing.Size(180, 22);
            this.btn_gestionarArticulos.Text = "Gestionar Articulos";
            this.btn_gestionarArticulos.Click += new System.EventHandler(this.btn_gestionarArticulos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 629);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsb_articulos;
        private ToolStripMenuItem btn_gestionarArticulos;
    }
}