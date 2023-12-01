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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionListas));
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            btn_new = new Button();
            panel4 = new Panel();
            label2 = new Label();
            lbl_todos = new Label();
            btn_massive = new Button();
            btn_save = new Button();
            txt_ganancia = new TextBox();
            label1 = new Label();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
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
            panel1.Controls.Add(btn_new);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lbl_listas);
            panel1.Controls.Add(dgv_listas);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 319);
            panel1.TabIndex = 6;
            // 
            // btn_new
            // 
            btn_new.BackgroundImage = Properties.Resources.plus1;
            btn_new.BackgroundImageLayout = ImageLayout.Stretch;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_new.Location = new Point(328, 236);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(46, 46);
            btn_new.TabIndex = 16;
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lbl_todos);
            panel4.Controls.Add(btn_massive);
            panel4.Controls.Add(btn_save);
            panel4.Controls.Add(txt_ganancia);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txt_nombre);
            panel4.Controls.Add(lbl_nombre);
            panel4.Location = new Point(406, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 237);
            panel4.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 201);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 44;
            label2.Text = "Guardar";
            // 
            // lbl_todos
            // 
            lbl_todos.AutoSize = true;
            lbl_todos.Location = new Point(174, 201);
            lbl_todos.Name = "lbl_todos";
            lbl_todos.Size = new Size(60, 15);
            lbl_todos.TabIndex = 43;
            lbl_todos.Text = "Regenerar";
            // 
            // btn_massive
            // 
            btn_massive.BackgroundImage = Properties.Resources.update_all;
            btn_massive.BackgroundImageLayout = ImageLayout.Stretch;
            btn_massive.FlatAppearance.BorderSize = 0;
            btn_massive.FlatStyle = FlatStyle.Flat;
            btn_massive.Location = new Point(180, 151);
            btn_massive.Name = "btn_massive";
            btn_massive.Size = new Size(46, 46);
            btn_massive.TabIndex = 42;
            btn_massive.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = (Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(261, 151);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(46, 46);
            btn_save.TabIndex = 41;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_ganancia
            // 
            txt_ganancia.Location = new Point(91, 85);
            txt_ganancia.Name = "txt_ganancia";
            txt_ganancia.Size = new Size(225, 23);
            txt_ganancia.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 36;
            label1.Text = "Ganancia %";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(90, 48);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 33;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(12, 51);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 34;
            lbl_nombre.Text = "Nombre";
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
            dgv_listas.Size = new Size(351, 185);
            dgv_listas.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_producto);
            panel2.Controls.Add(dgv_precios);
            panel2.Location = new Point(12, 394);
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
            ClientSize = new Size(787, 777);
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
        private Label lbl_producto;
        private Label lbl_listas;
        private Panel panel4;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private TextBox txt_ganancia;
        private Label label1;
        private Button btn_new;
        private Button btn_save;
        private Button btn_massive;
        private Label lbl_todos;
        private Label label2;
    }
}