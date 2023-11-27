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
            tsc_articulos = new ToolStripDropDownButton();
            btn_gestionarArticulos = new ToolStripMenuItem();
            listasToolStripMenuItem = new ToolStripMenuItem();
            ordenesDeCompraToolStripMenuItem = new ToolStripMenuItem();
            tsc_documentos = new ToolStripDropDownButton();
            informesToolStripMenuItem = new ToolStripMenuItem();
            generarListadosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            tsc_configuracion = new ToolStripDropDownButton();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            idiomasToolStripMenuItem = new ToolStripMenuItem();
            tsc_seguridad = new ToolStripDropDownButton();
            gestionarPermisosToolStripMenuItem = new ToolStripMenuItem();
            gestionarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            tsc_clientes = new ToolStripDropDownButton();
            gestionarClientesToolStripMenuItem = new ToolStripMenuItem();
            tsc_idioma = new ToolStripDropDownButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsc_articulos, tsc_documentos, tsc_configuracion, tsc_seguridad, tsc_clientes, tsc_idioma });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1183, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsc_articulos
            // 
            tsc_articulos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_articulos.DropDownItems.AddRange(new ToolStripItem[] { btn_gestionarArticulos, listasToolStripMenuItem, ordenesDeCompraToolStripMenuItem });
            tsc_articulos.Image = (Image)resources.GetObject("tsc_articulos.Image");
            tsc_articulos.ImageTransparentColor = Color.Magenta;
            tsc_articulos.Name = "tsc_articulos";
            tsc_articulos.Size = new Size(67, 22);
            tsc_articulos.Text = "Articulos";
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
            // tsc_documentos
            // 
            tsc_documentos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_documentos.DropDownItems.AddRange(new ToolStripItem[] { informesToolStripMenuItem, generarListadosToolStripMenuItem, ventasToolStripMenuItem });
            tsc_documentos.Image = (Image)resources.GetObject("tsc_documentos.Image");
            tsc_documentos.ImageTransparentColor = Color.Magenta;
            tsc_documentos.Name = "tsc_documentos";
            tsc_documentos.Size = new Size(88, 22);
            tsc_documentos.Text = "Documentos";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(180, 22);
            informesToolStripMenuItem.Text = "Informes";
            // 
            // generarListadosToolStripMenuItem
            // 
            generarListadosToolStripMenuItem.Name = "generarListadosToolStripMenuItem";
            generarListadosToolStripMenuItem.Size = new Size(180, 22);
            generarListadosToolStripMenuItem.Text = "Generar Listados";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(180, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // tsc_configuracion
            // 
            tsc_configuracion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_configuracion.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, idiomasToolStripMenuItem });
            tsc_configuracion.Image = (Image)resources.GetObject("tsc_configuracion.Image");
            tsc_configuracion.ImageTransparentColor = Color.Magenta;
            tsc_configuracion.Name = "tsc_configuracion";
            tsc_configuracion.Size = new Size(96, 22);
            tsc_configuracion.Text = "Configuracion";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(180, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += OpenCategoriasForm;
            // 
            // idiomasToolStripMenuItem
            // 
            idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            idiomasToolStripMenuItem.Size = new Size(180, 22);
            idiomasToolStripMenuItem.Text = "Idiomas";
            // 
            // tsc_seguridad
            // 
            tsc_seguridad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_seguridad.DropDownItems.AddRange(new ToolStripItem[] { gestionarPermisosToolStripMenuItem, gestionarUsuariosToolStripMenuItem });
            tsc_seguridad.Image = (Image)resources.GetObject("tsc_seguridad.Image");
            tsc_seguridad.ImageTransparentColor = Color.Magenta;
            tsc_seguridad.Name = "tsc_seguridad";
            tsc_seguridad.Size = new Size(73, 22);
            tsc_seguridad.Text = "Seguridad";
            // 
            // gestionarPermisosToolStripMenuItem
            // 
            gestionarPermisosToolStripMenuItem.Name = "gestionarPermisosToolStripMenuItem";
            gestionarPermisosToolStripMenuItem.Size = new Size(180, 22);
            gestionarPermisosToolStripMenuItem.Text = "Gestionar Permisos";
            gestionarPermisosToolStripMenuItem.Click += gestionarPermisosToolStripMenuItem_Click;
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.Size = new Size(180, 22);
            gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            // 
            // tsc_clientes
            // 
            tsc_clientes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_clientes.DropDownItems.AddRange(new ToolStripItem[] { gestionarClientesToolStripMenuItem });
            tsc_clientes.Image = (Image)resources.GetObject("tsc_clientes.Image");
            tsc_clientes.ImageTransparentColor = Color.Magenta;
            tsc_clientes.Name = "tsc_clientes";
            tsc_clientes.Size = new Size(62, 22);
            tsc_clientes.Text = "Clientes";
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
        private ToolStripDropDownButton tsc_articulos;
        private ToolStripMenuItem btn_gestionarArticulos;
        private ToolStripDropDownButton tsc_seguridad;
        private ToolStripMenuItem gestionarPermisosToolStripMenuItem;
        private ToolStripDropDownButton tsc_configuracion;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem listasToolStripMenuItem;
        private ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private ToolStripDropDownButton tsc_documentos;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem idiomasToolStripMenuItem;
        private ToolStripMenuItem generarListadosToolStripMenuItem;
        private ToolStripDropDownButton tsc_clientes;
        private ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripDropDownButton tsc_idioma;
    }
}