namespace PD.Presentation.Forms.Articulos
{
    partial class GestionListas
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
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            btn_add = new Button();
            lbl_listas = new Label();
            dgv_listas = new DataGridView();
            panel2 = new Panel();
            lbl_producto = new Label();
            dgv_precios = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_precios).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 51);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.list;
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
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 6;
            label4.Text = "LISTAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lbl_listas);
            panel1.Controls.Add(dgv_listas);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 208);
            panel1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txt_nombre);
            panel4.Controls.Add(lbl_nombre);
            panel4.Controls.Add(btn_add);
            panel4.Location = new Point(406, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 140);
            panel4.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(91, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 36;
            label1.Text = "Ganancia %";
            // 
            // txt_nombre
            // 
            txt_nombre.Enabled = false;
            txt_nombre.Location = new Point(90, 22);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 33;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(12, 25);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 34;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(195, 96);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(120, 31);
            btn_add.TabIndex = 1;
            btn_add.Text = "Agregar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click_1;
            // 
            // lbl_listas
            // 
            lbl_listas.AutoSize = true;
            lbl_listas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_listas.Location = new Point(22, 11);
            lbl_listas.Name = "lbl_listas";
            lbl_listas.Size = new Size(49, 21);
            lbl_listas.TabIndex = 14;
            lbl_listas.Text = "Listas";
            // 
            // dgv_listas
            // 
            dgv_listas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listas.Location = new Point(23, 45);
            dgv_listas.Name = "dgv_listas";
            dgv_listas.RowHeadersWidth = 62;
            dgv_listas.RowTemplate.Height = 25;
            dgv_listas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listas.Size = new Size(351, 137);
            dgv_listas.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_producto);
            panel2.Controls.Add(dgv_precios);
            panel2.Location = new Point(12, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 371);
            panel2.TabIndex = 7;
            // 
            // lbl_producto
            // 
            lbl_producto.AutoSize = true;
            lbl_producto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_producto.Location = new Point(23, 11);
            lbl_producto.Name = "lbl_producto";
            lbl_producto.Size = new Size(80, 21);
            lbl_producto.TabIndex = 13;
            lbl_producto.Text = "Productos";
            // 
            // dgv_precios
            // 
            dgv_precios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_precios.Location = new Point(22, 44);
            dgv_precios.Name = "dgv_precios";
            dgv_precios.RowHeadersWidth = 62;
            dgv_precios.RowTemplate.Height = 25;
            dgv_precios.Size = new Size(717, 303);
            dgv_precios.TabIndex = 0;
            // 
            // GestionListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(787, 670);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionListas";
            Text = "GestionListas";
            Load += GestionListas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_precios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private DataGridView dgv_listas;
        private Panel panel2;
        private DataGridView dgv_precios;
        private Button btn_add;
        private Label lbl_producto;
        private Label lbl_listas;
        private Panel panel4;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private TextBox textBox1;
        private Label label1;
    }
}