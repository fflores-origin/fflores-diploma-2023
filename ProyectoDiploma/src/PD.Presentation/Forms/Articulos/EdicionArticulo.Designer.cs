﻿namespace PD.Presentation.Forms.Articulos
{
    partial class EdicionArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionArticulo));
            lbl_nombre = new Label();
            panel1 = new Panel();
            lbl_title_libros = new Label();
            txt_autor = new TextBox();
            lbl_autor = new Label();
            txt_isbn = new TextBox();
            lbl_isbn = new Label();
            txt_id = new TextBox();
            lbl_id = new Label();
            txt_codigo = new TextBox();
            lbl_codigo = new Label();
            dgv_listas = new DataGridView();
            textBox1 = new TextBox();
            lbl_precio_lista = new Label();
            lbl_lista = new Label();
            lbl_almacen = new Label();
            txt_ubicacion = new TextBox();
            lbl_ubicacion = new Label();
            txt_cantidad = new TextBox();
            lbl_cantidad = new Label();
            txt_marca = new TextBox();
            txt_precio = new TextBox();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            btn_assign = new Button();
            lbl_general = new Label();
            cbx_categoria = new ComboBox();
            lbl_categoria = new Label();
            lbl_marca = new Label();
            lbl_precio_unitario = new Label();
            lbl_descripcion = new Label();
            btn_print = new Button();
            pic_qr = new PictureBox();
            lbl_article_title = new Label();
            panel2 = new Panel();
            lbl_image = new Label();
            panel6 = new Panel();
            btn_image_change = new Button();
            pic_base = new PictureBox();
            panel3 = new Panel();
            btn_help = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            lbl_save = new Label();
            btn_save = new Button();
            help_provider_articulo = new HelpProvider();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_qr).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_base).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(28, 95);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_title_libros);
            panel1.Controls.Add(txt_autor);
            panel1.Controls.Add(lbl_autor);
            panel1.Controls.Add(txt_isbn);
            panel1.Controls.Add(lbl_isbn);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lbl_id);
            panel1.Controls.Add(txt_codigo);
            panel1.Controls.Add(lbl_codigo);
            panel1.Controls.Add(dgv_listas);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbl_precio_lista);
            panel1.Controls.Add(lbl_lista);
            panel1.Controls.Add(lbl_almacen);
            panel1.Controls.Add(txt_ubicacion);
            panel1.Controls.Add(lbl_ubicacion);
            panel1.Controls.Add(txt_cantidad);
            panel1.Controls.Add(lbl_cantidad);
            panel1.Controls.Add(txt_marca);
            panel1.Controls.Add(txt_precio);
            panel1.Controls.Add(txt_descripcion);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(btn_assign);
            panel1.Controls.Add(lbl_general);
            panel1.Controls.Add(cbx_categoria);
            panel1.Controls.Add(lbl_categoria);
            panel1.Controls.Add(lbl_marca);
            panel1.Controls.Add(lbl_precio_unitario);
            panel1.Controls.Add(lbl_descripcion);
            panel1.Controls.Add(lbl_nombre);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 462);
            panel1.TabIndex = 2;
            // 
            // lbl_title_libros
            // 
            lbl_title_libros.AutoSize = true;
            lbl_title_libros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title_libros.Location = new Point(28, 325);
            lbl_title_libros.Name = "lbl_title_libros";
            lbl_title_libros.Size = new Size(46, 21);
            lbl_title_libros.TabIndex = 37;
            lbl_title_libros.Text = "Libro";
            // 
            // txt_autor
            // 
            txt_autor.BorderStyle = BorderStyle.FixedSingle;
            txt_autor.Location = new Point(121, 398);
            txt_autor.Name = "txt_autor";
            txt_autor.Size = new Size(225, 23);
            txt_autor.TabIndex = 8;
            // 
            // lbl_autor
            // 
            lbl_autor.AutoSize = true;
            lbl_autor.Location = new Point(28, 400);
            lbl_autor.Name = "lbl_autor";
            lbl_autor.Size = new Size(37, 15);
            lbl_autor.TabIndex = 36;
            lbl_autor.Text = "Autor";
            // 
            // txt_isbn
            // 
            txt_isbn.BorderStyle = BorderStyle.FixedSingle;
            txt_isbn.Location = new Point(121, 359);
            txt_isbn.Name = "txt_isbn";
            txt_isbn.Size = new Size(225, 23);
            txt_isbn.TabIndex = 7;
            // 
            // lbl_isbn
            // 
            lbl_isbn.AutoSize = true;
            lbl_isbn.Location = new Point(28, 362);
            lbl_isbn.Name = "lbl_isbn";
            lbl_isbn.Size = new Size(32, 15);
            lbl_isbn.TabIndex = 34;
            lbl_isbn.Text = "ISBN";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(255, 255, 192);
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Enabled = false;
            txt_id.Location = new Point(121, 52);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(225, 23);
            txt_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(28, 55);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(18, 15);
            lbl_id.TabIndex = 32;
            lbl_id.Text = "ID";
            // 
            // txt_codigo
            // 
            txt_codigo.BorderStyle = BorderStyle.FixedSingle;
            txt_codigo.Location = new Point(121, 247);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(225, 23);
            txt_codigo.TabIndex = 5;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Location = new Point(28, 250);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(46, 15);
            lbl_codigo.TabIndex = 30;
            lbl_codigo.Text = "Codigo";
            // 
            // dgv_listas
            // 
            dgv_listas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listas.Location = new Point(388, 54);
            dgv_listas.Margin = new Padding(10);
            dgv_listas.Name = "dgv_listas";
            dgv_listas.RowTemplate.Height = 25;
            dgv_listas.Size = new Size(315, 142);
            dgv_listas.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(478, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 10;
            // 
            // lbl_precio_lista
            // 
            lbl_precio_lista.AutoSize = true;
            lbl_precio_lista.Location = new Point(388, 212);
            lbl_precio_lista.Name = "lbl_precio_lista";
            lbl_precio_lista.Size = new Size(67, 15);
            lbl_precio_lista.TabIndex = 25;
            lbl_precio_lista.Text = "Precio Lista";
            // 
            // lbl_lista
            // 
            lbl_lista.AutoSize = true;
            lbl_lista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lista.Location = new Point(385, 15);
            lbl_lista.Name = "lbl_lista";
            lbl_lista.Size = new Size(49, 21);
            lbl_lista.TabIndex = 24;
            lbl_lista.Text = "Listas";
            // 
            // lbl_almacen
            // 
            lbl_almacen.AutoSize = true;
            lbl_almacen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_almacen.Location = new Point(388, 325);
            lbl_almacen.Name = "lbl_almacen";
            lbl_almacen.Size = new Size(70, 21);
            lbl_almacen.TabIndex = 23;
            lbl_almacen.Text = "Almacen";
            // 
            // txt_ubicacion
            // 
            txt_ubicacion.BorderStyle = BorderStyle.FixedSingle;
            txt_ubicacion.Location = new Point(481, 398);
            txt_ubicacion.Name = "txt_ubicacion";
            txt_ubicacion.Size = new Size(225, 23);
            txt_ubicacion.TabIndex = 21;
            // 
            // lbl_ubicacion
            // 
            lbl_ubicacion.AutoSize = true;
            lbl_ubicacion.Location = new Point(388, 400);
            lbl_ubicacion.Name = "lbl_ubicacion";
            lbl_ubicacion.Size = new Size(60, 15);
            lbl_ubicacion.TabIndex = 21;
            lbl_ubicacion.Text = "Ubicacion";
            // 
            // txt_cantidad
            // 
            txt_cantidad.BorderStyle = BorderStyle.FixedSingle;
            txt_cantidad.Location = new Point(481, 359);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(225, 23);
            txt_cantidad.TabIndex = 20;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(388, 362);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(48, 15);
            lbl_cantidad.TabIndex = 19;
            lbl_cantidad.Text = "Catidad";
            // 
            // txt_marca
            // 
            txt_marca.BorderStyle = BorderStyle.FixedSingle;
            txt_marca.Location = new Point(121, 209);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(225, 23);
            txt_marca.TabIndex = 4;
            // 
            // txt_precio
            // 
            txt_precio.BorderStyle = BorderStyle.FixedSingle;
            txt_precio.Location = new Point(121, 170);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(225, 23);
            txt_precio.TabIndex = 3;
            // 
            // txt_descripcion
            // 
            txt_descripcion.BorderStyle = BorderStyle.FixedSingle;
            txt_descripcion.Location = new Point(121, 131);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(225, 23);
            txt_descripcion.TabIndex = 2;
            // 
            // txt_nombre
            // 
            txt_nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre.Location = new Point(121, 92);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 1;
            // 
            // btn_assign
            // 
            btn_assign.BackColor = Color.White;
            btn_assign.FlatStyle = FlatStyle.Flat;
            btn_assign.Location = new Point(478, 242);
            btn_assign.Name = "btn_assign";
            btn_assign.Size = new Size(225, 29);
            btn_assign.TabIndex = 11;
            btn_assign.Text = "Actualizar Precio";
            btn_assign.UseVisualStyleBackColor = false;
            btn_assign.Click += btn_assign_Click;
            // 
            // lbl_general
            // 
            lbl_general.AutoSize = true;
            lbl_general.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_general.Location = new Point(26, 15);
            lbl_general.Name = "lbl_general";
            lbl_general.Size = new Size(64, 21);
            lbl_general.TabIndex = 12;
            lbl_general.Text = "General";
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(121, 286);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(225, 23);
            cbx_categoria.TabIndex = 6;
            cbx_categoria.SelectedIndexChanged += OnCategoriaChange;
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Location = new Point(28, 289);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(58, 15);
            lbl_categoria.TabIndex = 9;
            lbl_categoria.Text = "Categoria";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(28, 212);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 8;
            lbl_marca.Text = "Marca";
            // 
            // lbl_precio_unitario
            // 
            lbl_precio_unitario.AutoSize = true;
            lbl_precio_unitario.Location = new Point(28, 173);
            lbl_precio_unitario.Name = "lbl_precio_unitario";
            lbl_precio_unitario.Size = new Size(85, 15);
            lbl_precio_unitario.TabIndex = 5;
            lbl_precio_unitario.Text = "Precio Unitario";
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Location = new Point(28, 134);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(69, 15);
            lbl_descripcion.TabIndex = 3;
            lbl_descripcion.Text = "Descripcion";
            // 
            // btn_print
            // 
            btn_print.BackgroundImageLayout = ImageLayout.Stretch;
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Location = new Point(156, 309);
            btn_print.Margin = new Padding(0);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(72, 117);
            btn_print.TabIndex = 40;
            btn_print.Text = "Imprimir QR";
            btn_print.UseVisualStyleBackColor = true;
            // 
            // pic_qr
            // 
            pic_qr.BackgroundImageLayout = ImageLayout.Stretch;
            pic_qr.BorderStyle = BorderStyle.FixedSingle;
            pic_qr.ErrorImage = Properties.Resources.no_available;
            pic_qr.Location = new Point(36, 309);
            pic_qr.Name = "pic_qr";
            pic_qr.Size = new Size(117, 117);
            pic_qr.TabIndex = 27;
            pic_qr.TabStop = false;
            // 
            // lbl_article_title
            // 
            lbl_article_title.AutoSize = true;
            lbl_article_title.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_article_title.Location = new Point(54, 9);
            lbl_article_title.Name = "lbl_article_title";
            lbl_article_title.Size = new Size(126, 32);
            lbl_article_title.TabIndex = 6;
            lbl_article_title.Text = "ARTICULO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_image);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(pic_qr);
            panel2.Controls.Add(btn_print);
            panel2.Location = new Point(774, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 462);
            panel2.TabIndex = 3;
            // 
            // lbl_image
            // 
            lbl_image.AutoSize = true;
            lbl_image.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_image.Location = new Point(25, 15);
            lbl_image.Name = "lbl_image";
            lbl_image.Size = new Size(62, 21);
            lbl_image.TabIndex = 15;
            lbl_image.Text = "Imagen";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btn_image_change);
            panel6.Controls.Add(pic_base);
            panel6.Location = new Point(25, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(215, 241);
            panel6.TabIndex = 2;
            // 
            // btn_image_change
            // 
            btn_image_change.BackColor = Color.White;
            btn_image_change.FlatAppearance.BorderColor = Color.Black;
            btn_image_change.FlatStyle = FlatStyle.Flat;
            btn_image_change.Location = new Point(11, 202);
            btn_image_change.Name = "btn_image_change";
            btn_image_change.Size = new Size(192, 29);
            btn_image_change.TabIndex = 30;
            btn_image_change.Text = "Cambiar Imagen";
            btn_image_change.UseVisualStyleBackColor = false;
            btn_image_change.Click += btn_image_change_Click;
            // 
            // pic_base
            // 
            pic_base.BackgroundImage = (Image)resources.GetObject("pic_base.BackgroundImage");
            pic_base.BackgroundImageLayout = ImageLayout.Stretch;
            pic_base.Location = new Point(11, 9);
            pic_base.Name = "pic_base";
            pic_base.Size = new Size(192, 187);
            pic_base.TabIndex = 0;
            pic_base.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_help);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lbl_article_title);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1024, 51);
            panel3.TabIndex = 4;
            // 
            // btn_help
            // 
            btn_help.BackgroundImage = Properties.Resources.light_bulb;
            btn_help.BackgroundImageLayout = ImageLayout.Stretch;
            btn_help.FlatAppearance.BorderSize = 0;
            btn_help.FlatStyle = FlatStyle.Flat;
            btn_help.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            help_provider_articulo.SetHelpKeyword(btn_help, "CreacionArticulo");
            help_provider_articulo.SetHelpNavigator(btn_help, HelpNavigator.TopicId);
            btn_help.Location = new Point(985, 9);
            btn_help.Margin = new Padding(5);
            btn_help.Name = "btn_help";
            help_provider_articulo.SetShowHelp(btn_help, true);
            btn_help.Size = new Size(34, 32);
            btn_help.TabIndex = 19;
            btn_help.UseVisualStyleBackColor = true;
            btn_help.Click += btn_help_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.newspaper;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 45);
            panel5.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lbl_save);
            panel4.Controls.Add(btn_save);
            panel4.Location = new Point(12, 537);
            panel4.Name = "panel4";
            panel4.Size = new Size(1024, 106);
            panel4.TabIndex = 7;
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(930, 81);
            lbl_save.Name = "lbl_save";
            lbl_save.Size = new Size(49, 15);
            lbl_save.TabIndex = 14;
            lbl_save.Text = "Guardar";
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = (Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(924, 14);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(60, 60);
            btn_save.TabIndex = 50;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // help_provider_articulo
            // 
            help_provider_articulo.HelpNamespace = "J:\\PROJECTS\\UAI\\fflores-diploma-2023\\ProyectoDiploma\\src\\HelpProviderChm\\diploma.chm";
            // 
            // EdicionArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1049, 656);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EdicionArticulo";
            Text = "Edicion";
            Load += EdicionArticulo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_qr).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_base).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_nombre;
        private Panel panel1;
        private Label lbl_descripcion;
        private Label lbl_precio_unitario;
        private Label lbl_article_title;
        private Label lbl_marca;
        private Panel panel2;
        private PictureBox pic_base;
        private Label lbl_categoria;
        private ComboBox cbx_categoria;
        private Panel panel3;
        private Panel panel4;
        private Label lbl_general;
        private Button btn_save;
        private Panel panel5;
        private Panel panel6;
        private Label lbl_save;
        private Button btn_assign;
        private Label lbl_image;
        private Button btn_image_change;
        private TextBox txt_marca;
        private TextBox txt_precio;
        private TextBox txt_descripcion;
        private TextBox txt_nombre;
        private TextBox txt_cantidad;
        private Label lbl_cantidad;
        private TextBox txt_ubicacion;
        private Label lbl_ubicacion;
        private Label lbl_lista;
        private Label lbl_almacen;
        private TextBox textBox1;
        private Label lbl_precio_lista;
        private PictureBox pic_qr;
        private Button btn_print;
        private DataGridView dgv_listas;
        private TextBox txt_codigo;
        private Label lbl_codigo;
        private TextBox txt_id;
        private Label lbl_id;
        private TextBox txt_isbn;
        private Label lbl_isbn;
        private Button btn_help;
        private HelpProvider help_provider_articulo;
        private TextBox txt_autor;
        private Label lbl_autor;
        private Label lbl_title_libros;
    }
}