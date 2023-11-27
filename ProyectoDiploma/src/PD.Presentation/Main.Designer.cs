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
            listasToolStripMenuItem = new ToolStripMenuItem();
            ordenesDeCompraToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            informesToolStripMenuItem = new ToolStripMenuItem();
            generarListadosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            idiomasToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            gestionarPermisosToolStripMenuItem = new ToolStripMenuItem();
            gestionarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton4 = new ToolStripDropDownButton();
            gestionarClientesToolStripMenuItem = new ToolStripMenuItem();
            tsc_idioma = new ToolStripDropDownButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_articulos, toolStripDropDownButton3, toolStripDropDownButton2, toolStripDropDownButton1, toolStripDropDownButton4, tsc_idioma });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1183, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsb_articulos
            // 
            tsb_articulos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_articulos.DropDownItems.AddRange(new ToolStripItem[] { btn_gestionarArticulos, listasToolStripMenuItem, ordenesDeCompraToolStripMenuItem });
            tsb_articulos.Image = (Image)resources.GetObject("tsb_articulos.Image");
            tsb_articulos.ImageTransparentColor = Color.Magenta;
            tsb_articulos.Name = "tsb_articulos";
            tsb_articulos.Size = new Size(67, 22);
            tsb_articulos.Text = "Articulos";
            // 
            // btn_gestionarArticulos
            // 
            btn_gestionarArticulos.Name = "btn_gestionarArticulos";
            btn_gestionarArticulos.Size = new Size(180, 22);
            btn_gestionarArticulos.Text = "Gestionar Articulos";
            btn_gestionarArticulos.Click += Btn_gestionarArticulos_Click;
            // 
            // listasToolStripMenuItem
            // 
            listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            listasToolStripMenuItem.Size = new Size(180, 22);
            listasToolStripMenuItem.Text = "Gestionar Listas";
            listasToolStripMenuItem.Click += listasToolStripMenuItem_Click;
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            ordenesDeCompraToolStripMenuItem.Size = new Size(180, 22);
            ordenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra";
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { informesToolStripMenuItem, generarListadosToolStripMenuItem, ventasToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(88, 22);
            toolStripDropDownButton3.Text = "Documentos";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(161, 22);
            informesToolStripMenuItem.Text = "Informes";
            // 
            // generarListadosToolStripMenuItem
            // 
            generarListadosToolStripMenuItem.Name = "generarListadosToolStripMenuItem";
            generarListadosToolStripMenuItem.Size = new Size(161, 22);
            generarListadosToolStripMenuItem.Text = "Generar Listados";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(161, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, idiomasToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(96, 22);
            toolStripDropDownButton2.Text = "Configuracion";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += OpenCategoriasForm;
            // 
            // idiomasToolStripMenuItem
            // 
            idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            idiomasToolStripMenuItem.Size = new Size(130, 22);
            idiomasToolStripMenuItem.Text = "Idiomas";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { gestionarPermisosToolStripMenuItem, gestionarUsuariosToolStripMenuItem });
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
            // gestionarUsuariosToolStripMenuItem
            // 
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.Size = new Size(175, 22);
            gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            // 
            // toolStripDropDownButton4
            // 
            toolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton4.DropDownItems.AddRange(new ToolStripItem[] { gestionarClientesToolStripMenuItem });
            toolStripDropDownButton4.Image = (Image)resources.GetObject("toolStripDropDownButton4.Image");
            toolStripDropDownButton4.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            toolStripDropDownButton4.Size = new Size(62, 22);
            toolStripDropDownButton4.Text = "Clientes";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            gestionarClientesToolStripMenuItem.Size = new Size(180, 22);
            gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            // 
            // tsc_idioma
            // 
            tsc_idioma.Name = "tsc_idioma";
            tsc_idioma.Size = new Size(57, 22);
            tsc_idioma.Text = "Idioma";
            tsc_idioma.Click += tsc_idioma_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1183, 813);
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
        private ToolStripMenuItem listasToolStripMenuItem;
        private ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem idiomasToolStripMenuItem;
        private ToolStripMenuItem generarListadosToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripDropDownButton tsc_idioma;
    }
}