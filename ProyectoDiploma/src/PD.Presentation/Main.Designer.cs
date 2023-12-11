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
            ts_main = new MenuStrip();
            tsc_articulos = new ToolStripDropDownButton();
            tsb_gestionarArticulos = new ToolStripMenuItem();
            tsb_Listas = new ToolStripMenuItem();
            tsb_gestionarPedidos = new ToolStripMenuItem();
            tsb_ordenesDeCompra = new ToolStripMenuItem();
            tsc_documentos = new ToolStripDropDownButton();
            informesToolStripMenuItem = new ToolStripMenuItem();
            generarListadosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            tsc_configuracion = new ToolStripDropDownButton();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            idiomasToolStripMenuItem = new ToolStripMenuItem();
            tsc_seguridad = new ToolStripDropDownButton();
            tsb_gestionarPermisos = new ToolStripMenuItem();
            tsb_gestionarUsuarios = new ToolStripMenuItem();
            tsc_clientes = new ToolStripDropDownButton();
            tsb_gestionarClientes = new ToolStripMenuItem();
            tsc_idioma = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            help_provider_main = new HelpProvider();
            ts_main.SuspendLayout();
            SuspendLayout();
            // 
            // ts_main
            // 
            ts_main.Items.AddRange(new ToolStripItem[] { tsc_articulos, tsc_documentos, tsc_configuracion, tsc_seguridad, tsc_clientes, tsc_idioma, toolStripMenuItem1 });
            ts_main.Location = new Point(0, 0);
            ts_main.Name = "ts_main";
            ts_main.Size = new Size(1183, 29);
            ts_main.TabIndex = 1;
            ts_main.Text = "toolStrip1";
            // 
            // tsc_articulos
            // 
            tsc_articulos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_articulos.DropDownItems.AddRange(new ToolStripItem[] { tsb_gestionarArticulos, tsb_Listas, tsb_gestionarPedidos, tsb_ordenesDeCompra });
            tsc_articulos.Image = (Image)resources.GetObject("tsc_articulos.Image");
            tsc_articulos.ImageTransparentColor = Color.Magenta;
            tsc_articulos.Name = "tsc_articulos";
            tsc_articulos.Size = new Size(67, 22);
            tsc_articulos.Tag = "tsc_articulos";
            tsc_articulos.Text = "Articulos";
            // 
            // tsb_gestionarArticulos
            // 
            tsb_gestionarArticulos.Name = "tsb_gestionarArticulos";
            tsb_gestionarArticulos.Size = new Size(180, 22);
            tsb_gestionarArticulos.Text = "Gestionar Articulos";
            tsb_gestionarArticulos.Click += Btn_gestionarArticulos_Click;
            // 
            // tsb_Listas
            // 
            tsb_Listas.Name = "tsb_Listas";
            tsb_Listas.Size = new Size(180, 22);
            tsb_Listas.Text = "Gestionar Listas";
            tsb_Listas.Click += listasToolStripMenuItem_Click;
            // 
            // tsb_gestionarPedidos
            // 
            tsb_gestionarPedidos.Name = "tsb_gestionarPedidos";
            tsb_gestionarPedidos.Size = new Size(180, 22);
            tsb_gestionarPedidos.Text = "Gestionar Pedidos";
            tsb_gestionarPedidos.Click += gestionarPedidosToolStripMenuItem_Click;
            // 
            // tsb_ordenesDeCompra
            // 
            tsb_ordenesDeCompra.Name = "tsb_ordenesDeCompra";
            tsb_ordenesDeCompra.Size = new Size(180, 22);
            tsb_ordenesDeCompra.Text = "Ordenes de Compra";
            tsb_ordenesDeCompra.Click += tsb_ordenesDeCompra_Click;
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
            // tsc_seguridad
            // 
            tsc_seguridad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_seguridad.DropDownItems.AddRange(new ToolStripItem[] { tsb_gestionarPermisos, tsb_gestionarUsuarios });
            tsc_seguridad.Image = (Image)resources.GetObject("tsc_seguridad.Image");
            tsc_seguridad.ImageTransparentColor = Color.Magenta;
            tsc_seguridad.Name = "tsc_seguridad";
            tsc_seguridad.Size = new Size(73, 22);
            tsc_seguridad.Text = "Seguridad";
            // 
            // tsb_gestionarPermisos
            // 
            tsb_gestionarPermisos.Name = "tsb_gestionarPermisos";
            tsb_gestionarPermisos.Size = new Size(175, 22);
            tsb_gestionarPermisos.Text = "Gestionar Permisos";
            tsb_gestionarPermisos.Click += gestionarPermisosToolStripMenuItem_Click;
            // 
            // tsb_gestionarUsuarios
            // 
            tsb_gestionarUsuarios.Name = "tsb_gestionarUsuarios";
            tsb_gestionarUsuarios.Size = new Size(175, 22);
            tsb_gestionarUsuarios.Text = "Gestionar Usuarios";
            // 
            // tsc_clientes
            // 
            tsc_clientes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsc_clientes.DropDownItems.AddRange(new ToolStripItem[] { tsb_gestionarClientes });
            tsc_clientes.Image = (Image)resources.GetObject("tsc_clientes.Image");
            tsc_clientes.ImageTransparentColor = Color.Magenta;
            tsc_clientes.Name = "tsc_clientes";
            tsc_clientes.Size = new Size(62, 22);
            tsc_clientes.Text = "Clientes";
            // 
            // tsb_gestionarClientes
            // 
            tsb_gestionarClientes.Name = "tsb_gestionarClientes";
            tsb_gestionarClientes.Size = new Size(169, 22);
            tsb_gestionarClientes.Text = "Gestionar Clientes";
            tsb_gestionarClientes.Click += gestionarClientesToolStripMenuItem_Click;
            // 
            // tsc_idioma
            // 
            tsc_idioma.Name = "tsc_idioma";
            tsc_idioma.Size = new Size(57, 22);
            tsc_idioma.Text = "Idioma";
            tsc_idioma.Click += tsc_idioma_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(29, 25);
            toolStripMenuItem1.Text = "?";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1183, 813);
            Controls.Add(ts_main);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            ts_main.ResumeLayout(false);
            ts_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ts_main;
        private ToolStripDropDownButton tsc_articulos;
        private ToolStripMenuItem tsb_gestionarArticulos;
        private ToolStripDropDownButton tsc_seguridad;
        private ToolStripMenuItem tsb_gestionarPermisos;
        private ToolStripDropDownButton tsc_configuracion;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem tsb_Listas;
        private ToolStripMenuItem tsb_gestionarUsuarios;
        private ToolStripMenuItem tsb_ordenesDeCompra;
        private ToolStripDropDownButton tsc_documentos;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem idiomasToolStripMenuItem;
        private ToolStripMenuItem generarListadosToolStripMenuItem;
        private ToolStripDropDownButton tsc_clientes;
        private ToolStripMenuItem tsb_gestionarClientes;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripDropDownButton tsc_idioma;
        private ToolStripMenuItem tsb_gestionarPedidos;
        private ToolStripMenuItem toolStripMenuItem1;
        private HelpProvider help_provider_main;
    }
}