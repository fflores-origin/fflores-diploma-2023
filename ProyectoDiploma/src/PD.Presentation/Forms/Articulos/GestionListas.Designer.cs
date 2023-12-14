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
            lbl_title_lista = new Label();
            pnl_lista = new Panel();
            btn_new = new Button();
            pnl_edicion = new Panel();
            txt_id = new TextBox();
            lbl_id = new Label();
            lbl_save = new Label();
            lbl_todos = new Label();
            btn_massive = new Button();
            btn_save = new Button();
            txt_ganancia = new TextBox();
            lbl_ganancia = new Label();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            lbl_listas = new Label();
            dgv_listas = new DataGridView();
            pnl_productos = new Panel();
            lbl_producto = new Label();
            dgv_precios = new DataGridView();
            panel3.SuspendLayout();
            pnl_lista.SuspendLayout();
            pnl_edicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listas).BeginInit();
            pnl_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_precios).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lbl_title_lista);
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
            // lbl_title_lista
            // 
            lbl_title_lista.AutoSize = true;
            lbl_title_lista.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title_lista.Location = new Point(54, 11);
            lbl_title_lista.Name = "lbl_title_lista";
            lbl_title_lista.Size = new Size(98, 32);
            lbl_title_lista.TabIndex = 6;
            lbl_title_lista.Tag = "lbl_title_lista";
            lbl_title_lista.Text = "LISTAS";
            // 
            // pnl_lista
            // 
            pnl_lista.BackColor = Color.White;
            pnl_lista.Controls.Add(btn_new);
            pnl_lista.Controls.Add(pnl_edicion);
            pnl_lista.Controls.Add(lbl_listas);
            pnl_lista.Controls.Add(dgv_listas);
            pnl_lista.Location = new Point(12, 69);
            pnl_lista.Name = "pnl_lista";
            pnl_lista.Size = new Size(763, 319);
            pnl_lista.TabIndex = 6;
            // 
            // btn_new
            // 
            btn_new.BackgroundImage = Properties.Resources.plus1;
            btn_new.BackgroundImageLayout = ImageLayout.Stretch;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_new.Location = new Point(328, 256);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(46, 46);
            btn_new.TabIndex = 16;
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // pnl_edicion
            // 
            pnl_edicion.BackColor = Color.White;
            pnl_edicion.Controls.Add(txt_id);
            pnl_edicion.Controls.Add(lbl_id);
            pnl_edicion.Controls.Add(lbl_save);
            pnl_edicion.Controls.Add(lbl_todos);
            pnl_edicion.Controls.Add(btn_massive);
            pnl_edicion.Controls.Add(btn_save);
            pnl_edicion.Controls.Add(txt_ganancia);
            pnl_edicion.Controls.Add(lbl_ganancia);
            pnl_edicion.Controls.Add(txt_nombre);
            pnl_edicion.Controls.Add(lbl_nombre);
            pnl_edicion.Location = new Point(406, 45);
            pnl_edicion.Name = "pnl_edicion";
            pnl_edicion.Size = new Size(333, 257);
            pnl_edicion.TabIndex = 15;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(90, 23);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(225, 23);
            txt_id.TabIndex = 45;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(14, 28);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(18, 15);
            lbl_id.TabIndex = 46;
            lbl_id.Text = "ID";
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(260, 216);
            lbl_save.Name = "lbl_save";
            lbl_save.Size = new Size(49, 15);
            lbl_save.TabIndex = 44;
            lbl_save.Text = "Guardar";
            // 
            // lbl_todos
            // 
            lbl_todos.AutoSize = true;
            lbl_todos.Location = new Point(174, 216);
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
            btn_massive.Location = new Point(180, 166);
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
            btn_save.Location = new Point(261, 166);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(46, 46);
            btn_save.TabIndex = 41;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_ganancia
            // 
            txt_ganancia.Location = new Point(91, 100);
            txt_ganancia.Name = "txt_ganancia";
            txt_ganancia.Size = new Size(225, 23);
            txt_ganancia.TabIndex = 35;
            // 
            // lbl_ganancia
            // 
            lbl_ganancia.AutoSize = true;
            lbl_ganancia.Location = new Point(12, 105);
            lbl_ganancia.Name = "lbl_ganancia";
            lbl_ganancia.Size = new Size(69, 15);
            lbl_ganancia.TabIndex = 36;
            lbl_ganancia.Text = "Ganancia %";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(90, 63);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 33;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(12, 68);
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
            dgv_listas.ShowEditingIcon = false;
            dgv_listas.Size = new Size(351, 205);
            dgv_listas.TabIndex = 0;
            // 
            // pnl_productos
            // 
            pnl_productos.BackColor = Color.White;
            pnl_productos.Controls.Add(lbl_producto);
            pnl_productos.Controls.Add(dgv_precios);
            pnl_productos.Location = new Point(12, 394);
            pnl_productos.Name = "pnl_productos";
            pnl_productos.Size = new Size(763, 281);
            pnl_productos.TabIndex = 7;
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
            dgv_precios.Size = new Size(717, 211);
            dgv_precios.TabIndex = 0;
            // 
            // GestionListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(787, 684);
            Controls.Add(pnl_productos);
            Controls.Add(pnl_lista);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionListas";
            Load += GestionListas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnl_lista.ResumeLayout(false);
            pnl_lista.PerformLayout();
            pnl_edicion.ResumeLayout(false);
            pnl_edicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listas).EndInit();
            pnl_productos.ResumeLayout(false);
            pnl_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_precios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label lbl_title_lista;
        private Panel pnl_lista;
        private DataGridView dgv_listas;
        private Panel pnl_productos;
        private DataGridView dgv_precios;
        private Label lbl_producto;
        private Label lbl_listas;
        private Panel pnl_edicion;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private TextBox txt_ganancia;
        private Label lbl_ganancia;
        private Button btn_new;
        private Button btn_save;
        private Button btn_massive;
        private Label lbl_todos;
        private Label lbl_save;
        private TextBox txt_id;
        private Label lbl_id;
    }
}