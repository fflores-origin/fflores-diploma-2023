namespace PD.Presentation.Forms.Articulos
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
            label1 = new Label();
            panel1 = new Panel();
            txt_codigo = new TextBox();
            lbl_codigo = new Label();
            dgv_listas = new DataGridView();
            btn_print = new Button();
            pic_qr = new PictureBox();
            textBox1 = new TextBox();
            lbl_precio_lista = new Label();
            lbl_lista = new Label();
            lbl_almacen = new Label();
            txt_ubicacion = new TextBox();
            lbl_ubicacion = new Label();
            txt_cantidad = new TextBox();
            label9 = new Label();
            txt_marca = new TextBox();
            txt_precio = new TextBox();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            btn_assign = new Button();
            lbl_general = new Label();
            label7 = new Label();
            cbx_categoria = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lbl_image = new Label();
            panel6 = new Panel();
            btn_image_change = new Button();
            pic_base = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            lbl_save = new Label();
            btn_save = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_marca);
            panel1.Controls.Add(txt_precio);
            panel1.Controls.Add(txt_descripcion);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(btn_assign);
            panel1.Controls.Add(lbl_general);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbx_categoria);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 446);
            panel1.TabIndex = 2;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(119, 212);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(225, 23);
            txt_codigo.TabIndex = 31;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Location = new Point(26, 215);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(46, 15);
            lbl_codigo.TabIndex = 30;
            lbl_codigo.Text = "Codigo";
            // 
            // dgv_listas
            // 
            dgv_listas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_listas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listas.Location = new Point(478, 54);
            dgv_listas.Margin = new Padding(10);
            dgv_listas.Name = "dgv_listas";
            dgv_listas.RowTemplate.Height = 25;
            dgv_listas.Size = new Size(225, 99);
            dgv_listas.TabIndex = 29;
            // 
            // btn_print
            // 
            btn_print.BackgroundImageLayout = ImageLayout.Stretch;
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Location = new Point(185, 309);
            btn_print.Margin = new Padding(0);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(72, 117);
            btn_print.TabIndex = 28;
            btn_print.Text = "Imprimir QR";
            btn_print.UseVisualStyleBackColor = true;
            // 
            // pic_qr
            // 
            pic_qr.BackgroundImageLayout = ImageLayout.Stretch;
            pic_qr.BorderStyle = BorderStyle.FixedSingle;
            pic_qr.ErrorImage = Properties.Resources.no_available;
            pic_qr.Location = new Point(65, 309);
            pic_qr.Name = "pic_qr";
            pic_qr.Size = new Size(117, 117);
            pic_qr.TabIndex = 27;
            pic_qr.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(478, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 26;
            // 
            // lbl_precio_lista
            // 
            lbl_precio_lista.AutoSize = true;
            lbl_precio_lista.Location = new Point(388, 215);
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
            lbl_almacen.Location = new Point(26, 299);
            lbl_almacen.Name = "lbl_almacen";
            lbl_almacen.Size = new Size(70, 21);
            lbl_almacen.TabIndex = 23;
            lbl_almacen.Text = "Almacen";
            // 
            // txt_ubicacion
            // 
            txt_ubicacion.Location = new Point(119, 383);
            txt_ubicacion.Name = "txt_ubicacion";
            txt_ubicacion.Size = new Size(225, 23);
            txt_ubicacion.TabIndex = 22;
            // 
            // lbl_ubicacion
            // 
            lbl_ubicacion.AutoSize = true;
            lbl_ubicacion.Location = new Point(26, 386);
            lbl_ubicacion.Name = "lbl_ubicacion";
            lbl_ubicacion.Size = new Size(60, 15);
            lbl_ubicacion.TabIndex = 21;
            lbl_ubicacion.Text = "Ubicacion";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(119, 344);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(225, 23);
            txt_cantidad.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 347);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 19;
            label9.Text = "Catidad";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(119, 174);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(225, 23);
            txt_marca.TabIndex = 18;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(119, 135);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(225, 23);
            txt_precio.TabIndex = 17;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(119, 96);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(225, 23);
            txt_descripcion.TabIndex = 16;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(119, 57);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 15;
            // 
            // btn_assign
            // 
            btn_assign.Location = new Point(615, 163);
            btn_assign.Name = "btn_assign";
            btn_assign.Size = new Size(88, 29);
            btn_assign.TabIndex = 14;
            btn_assign.Text = "Asignar Lista";
            btn_assign.UseVisualStyleBackColor = true;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 54);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 11;
            label7.Text = "Lista";
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(119, 251);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(225, 23);
            cbx_categoria.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 254);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 9;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 177);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 138);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio Unitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "ARTICULO";
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
            panel2.Size = new Size(321, 446);
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
            panel6.Location = new Point(25, 54);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 239);
            panel6.TabIndex = 2;
            // 
            // btn_image_change
            // 
            btn_image_change.BackColor = Color.White;
            btn_image_change.FlatAppearance.BorderColor = Color.Black;
            btn_image_change.FlatStyle = FlatStyle.Flat;
            btn_image_change.Location = new Point(39, 198);
            btn_image_change.Name = "btn_image_change";
            btn_image_change.Size = new Size(192, 29);
            btn_image_change.TabIndex = 15;
            btn_image_change.Text = "Cambiar Imagen";
            btn_image_change.UseVisualStyleBackColor = false;
            btn_image_change.Click += btn_image_change_Click;
            // 
            // pic_base
            // 
            pic_base.BackgroundImage = (Image)resources.GetObject("pic_base.BackgroundImage");
            pic_base.BackgroundImageLayout = ImageLayout.Stretch;
            pic_base.Location = new Point(39, 5);
            pic_base.Name = "pic_base";
            pic_base.Size = new Size(192, 187);
            pic_base.TabIndex = 0;
            pic_base.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1083, 51);
            panel3.TabIndex = 4;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lbl_save);
            panel4.Controls.Add(btn_save);
            panel4.Location = new Point(12, 521);
            panel4.Name = "panel4";
            panel4.Size = new Size(1083, 122);
            panel4.TabIndex = 7;
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(988, 89);
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
            btn_save.Location = new Point(982, 26);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(60, 60);
            btn_save.TabIndex = 0;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // EdicionArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1104, 656);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private PictureBox pic_base;
        private Label label6;
        private ComboBox cbx_categoria;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
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
        private Label label9;
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
    }
}