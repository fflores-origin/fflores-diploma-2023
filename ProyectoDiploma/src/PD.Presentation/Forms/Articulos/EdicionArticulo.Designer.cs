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
            txt_marca = new TextBox();
            txt_precio = new TextBox();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            btn_assign = new Button();
            lst_listas = new ListBox();
            lbl_general = new Label();
            label7 = new Label();
            cbx_categoria = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            lbl_image = new Label();
            panel6 = new Panel();
            lbl_fileName = new Label();
            pic_base = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            button1 = new Button();
            lbl_save = new Label();
            btn_save = new Button();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(txt_marca);
            panel1.Controls.Add(txt_precio);
            panel1.Controls.Add(txt_descripcion);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(btn_assign);
            panel1.Controls.Add(lst_listas);
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
            panel1.Size = new Size(382, 372);
            panel1.TabIndex = 2;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(119, 169);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(225, 23);
            txt_marca.TabIndex = 18;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(119, 130);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(225, 23);
            txt_precio.TabIndex = 17;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(119, 91);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(225, 23);
            txt_descripcion.TabIndex = 16;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(119, 52);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 15;
            // 
            // btn_assign
            // 
            btn_assign.Location = new Point(256, 330);
            btn_assign.Name = "btn_assign";
            btn_assign.Size = new Size(88, 29);
            btn_assign.TabIndex = 14;
            btn_assign.Text = "Asignar Lista";
            btn_assign.UseVisualStyleBackColor = true;
            // 
            // lst_listas
            // 
            lst_listas.FormattingEnabled = true;
            lst_listas.ItemHeight = 15;
            lst_listas.Location = new Point(119, 260);
            lst_listas.Name = "lst_listas";
            lst_listas.Size = new Size(225, 64);
            lst_listas.TabIndex = 13;
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
            label7.Location = new Point(26, 260);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 11;
            label7.Text = "Lista";
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(119, 211);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(225, 23);
            cbx_categoria.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 219);
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
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(125, 29);
            label4.TabIndex = 6;
            label4.Text = "ARTICULO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lbl_image);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(400, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 372);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(184, 330);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 15;
            button2.Text = "Cambiar Imagen";
            button2.UseVisualStyleBackColor = true;
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
            panel6.Controls.Add(lbl_fileName);
            panel6.Controls.Add(pic_base);
            panel6.Location = new Point(25, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 279);
            panel6.TabIndex = 2;
            // 
            // lbl_fileName
            // 
            lbl_fileName.AutoSize = true;
            lbl_fileName.Location = new Point(10, 249);
            lbl_fileName.Name = "lbl_fileName";
            lbl_fileName.Size = new Size(55, 15);
            lbl_fileName.TabIndex = 1;
            lbl_fileName.Text = "fileName";
            // 
            // pic_base
            // 
            pic_base.BackgroundImage = (Image)resources.GetObject("pic_base.BackgroundImage");
            pic_base.BackgroundImageLayout = ImageLayout.Stretch;
            pic_base.Location = new Point(10, 6);
            pic_base.Name = "pic_base";
            pic_base.Size = new Size(250, 230);
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
            panel3.Size = new Size(709, 51);
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
            panel4.Controls.Add(label8);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(lbl_save);
            panel4.Controls.Add(btn_save);
            panel4.Location = new Point(12, 447);
            panel4.Name = "panel4";
            panel4.Size = new Size(709, 122);
            panel4.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 90);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 16;
            label8.Text = "QR";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(536, 21);
            button1.Name = "button1";
            button1.Size = new Size(60, 58);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(629, 90);
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
            btn_save.Location = new Point(624, 21);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(60, 58);
            btn_save.TabIndex = 0;
            btn_save.UseVisualStyleBackColor = true;
            // 
            // EdicionArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(733, 581);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EdicionArticulo";
            Text = "Edicion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private ListBox lst_listas;
        private Button btn_save;
        private Panel panel5;
        private Panel panel6;
        private Label lbl_fileName;
        private Label lbl_save;
        private Button button1;
        private Label label8;
        private Button btn_assign;
        private Label lbl_image;
        private Button button2;
        private TextBox txt_marca;
        private TextBox txt_precio;
        private TextBox txt_descripcion;
        private TextBox txt_nombre;
    }
}