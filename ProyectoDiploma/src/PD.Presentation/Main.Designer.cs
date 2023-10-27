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
            toolStrip1 = new ToolStrip();
            tsb_articulos = new ToolStripDropDownButton();
            btn_gestionarArticulos = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            gestionarPermisosToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_articulos, toolStripDropDownButton1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(861, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsb_articulos
            // 
            tsb_articulos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_articulos.DropDownItems.AddRange(new ToolStripItem[] { btn_gestionarArticulos });
            tsb_articulos.Image = (Image)resources.GetObject("tsb_articulos.Image");
            tsb_articulos.ImageTransparentColor = Color.Magenta;
            tsb_articulos.Name = "tsb_articulos";
            tsb_articulos.Size = new Size(67, 22);
            tsb_articulos.Text = "Articulos";
            // 
            // btn_gestionarArticulos
            // 
            btn_gestionarArticulos.Name = "btn_gestionarArticulos";
            btn_gestionarArticulos.Size = new Size(174, 22);
            btn_gestionarArticulos.Text = "Gestionar Articulos";
            btn_gestionarArticulos.Click += Btn_gestionarArticulos_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { gestionarPermisosToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(73, 22);
            toolStripDropDownButton1.Text = "Seguridad";
            // 
            // gestionarPermisosToolStripMenuItem
            // 
            gestionarPermisosToolStripMenuItem.Name = "gestionarPermisosToolStripMenuItem";
            gestionarPermisosToolStripMenuItem.Size = new Size(175, 22);
            gestionarPermisosToolStripMenuItem.Text = "Gestionar Permisos";
            gestionarPermisosToolStripMenuItem.Click += gestionarPermisosToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(96, 22);
            toolStripDropDownButton2.Text = "Configuracion";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(180, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += OpenCategoriasForm;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(861, 516);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsb_articulos;
        private ToolStripMenuItem btn_gestionarArticulos;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem gestionarPermisosToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem categoriasToolStripMenuItem;
    }
}