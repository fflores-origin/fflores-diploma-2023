namespace PD.Presentation.Forms.Pedidos
{
    partial class GestionarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPedidos));
            panel3 = new Panel();
            panel5 = new Panel();
            lbl_title_pedidos = new Label();
            panel1 = new Panel();
            lbl_fecha = new Label();
            txt_fecha = new TextBox();
            lbl_facturar = new Label();
            btn_bill = new Button();
            lbl_save = new Label();
            btn_save = new Button();
            btn_remove = new Button();
            btn_add = new Button();
            lbl_lista = new Label();
            cbx_lista = new ComboBox();
            dgv_productos = new DataGridView();
            lbl_cantidad = new Label();
            txt_cantidad = new TextBox();
            lbl_pedido = new Label();
            dgv_pedido = new DataGridView();
            cbx_clientes = new ComboBox();
            lbl_cliente = new Label();
            panel2 = new Panel();
            btn_new = new Button();
            dgv_lista_pedidos = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_pedido).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_lista_pedidos).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lbl_title_pedidos);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 51);
            panel3.TabIndex = 5;
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
            // lbl_title_pedidos
            // 
            lbl_title_pedidos.AutoSize = true;
            lbl_title_pedidos.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title_pedidos.Location = new Point(54, 11);
            lbl_title_pedidos.Name = "lbl_title_pedidos";
            lbl_title_pedidos.Size = new Size(112, 32);
            lbl_title_pedidos.TabIndex = 6;
            lbl_title_pedidos.Text = "PEDIDOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_fecha);
            panel1.Controls.Add(txt_fecha);
            panel1.Controls.Add(lbl_facturar);
            panel1.Controls.Add(btn_bill);
            panel1.Controls.Add(lbl_save);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_remove);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(lbl_lista);
            panel1.Controls.Add(cbx_lista);
            panel1.Controls.Add(dgv_productos);
            panel1.Controls.Add(lbl_cantidad);
            panel1.Controls.Add(txt_cantidad);
            panel1.Controls.Add(lbl_pedido);
            panel1.Controls.Add(dgv_pedido);
            panel1.Controls.Add(cbx_clientes);
            panel1.Controls.Add(lbl_cliente);
            panel1.Location = new Point(15, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 418);
            panel1.TabIndex = 8;
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(14, 48);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(38, 15);
            lbl_fecha.TabIndex = 20;
            lbl_fecha.Text = "Fecha";
            // 
            // txt_fecha
            // 
            txt_fecha.Enabled = false;
            txt_fecha.Location = new Point(111, 45);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(315, 23);
            txt_fecha.TabIndex = 19;
            // 
            // lbl_facturar
            // 
            lbl_facturar.AutoSize = true;
            lbl_facturar.Location = new Point(743, 387);
            lbl_facturar.Name = "lbl_facturar";
            lbl_facturar.Size = new Size(50, 15);
            lbl_facturar.TabIndex = 18;
            lbl_facturar.Text = "Facturar";
            // 
            // btn_bill
            // 
            btn_bill.BackgroundImage = Properties.Resources.bill;
            btn_bill.BackgroundImageLayout = ImageLayout.Stretch;
            btn_bill.FlatAppearance.BorderSize = 0;
            btn_bill.FlatStyle = FlatStyle.Flat;
            btn_bill.Location = new Point(747, 337);
            btn_bill.Name = "btn_bill";
            btn_bill.Size = new Size(46, 46);
            btn_bill.TabIndex = 17;
            btn_bill.UseVisualStyleBackColor = true;
            btn_bill.Click += btn_bill_Click;
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(809, 387);
            lbl_save.Name = "lbl_save";
            lbl_save.Size = new Size(49, 15);
            lbl_save.TabIndex = 16;
            lbl_save.Text = "Guardar";
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = Properties.Resources.save;
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(811, 337);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(46, 46);
            btn_save.TabIndex = 15;
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            btn_remove.BackgroundImage = Properties.Resources.arror_left;
            btn_remove.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Location = new Point(458, 313);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(46, 46);
            btn_remove.TabIndex = 14;
            btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.BackgroundImage = Properties.Resources.arror_right;
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Location = new Point(380, 313);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(46, 46);
            btn_add.TabIndex = 13;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // lbl_lista
            // 
            lbl_lista.AutoSize = true;
            lbl_lista.Location = new Point(14, 106);
            lbl_lista.Name = "lbl_lista";
            lbl_lista.Size = new Size(31, 15);
            lbl_lista.TabIndex = 10;
            lbl_lista.Text = "Lista";
            // 
            // cbx_lista
            // 
            cbx_lista.FormattingEnabled = true;
            cbx_lista.Location = new Point(111, 103);
            cbx_lista.Name = "cbx_lista";
            cbx_lista.Size = new Size(315, 23);
            cbx_lista.TabIndex = 9;
            cbx_lista.SelectedIndexChanged += OnSelectionListaChange;
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Location = new Point(14, 136);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersVisible = false;
            dgv_productos.RowTemplate.Height = 25;
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos.Size = new Size(412, 142);
            dgv_productos.TabIndex = 8;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(195, 287);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(55, 15);
            lbl_cantidad.TabIndex = 7;
            lbl_cantidad.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(263, 284);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(163, 23);
            txt_cantidad.TabIndex = 6;
            // 
            // lbl_pedido
            // 
            lbl_pedido.AutoSize = true;
            lbl_pedido.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pedido.Location = new Point(432, 15);
            lbl_pedido.Name = "lbl_pedido";
            lbl_pedido.Size = new Size(67, 25);
            lbl_pedido.TabIndex = 5;
            lbl_pedido.Text = "Pedido";
            // 
            // dgv_pedido
            // 
            dgv_pedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pedido.Location = new Point(432, 43);
            dgv_pedido.Name = "dgv_pedido";
            dgv_pedido.RowHeadersVisible = false;
            dgv_pedido.RowTemplate.Height = 25;
            dgv_pedido.Size = new Size(433, 235);
            dgv_pedido.TabIndex = 4;
            // 
            // cbx_clientes
            // 
            cbx_clientes.FormattingEnabled = true;
            cbx_clientes.Location = new Point(111, 74);
            cbx_clientes.Name = "cbx_clientes";
            cbx_clientes.Size = new Size(315, 23);
            cbx_clientes.TabIndex = 2;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Location = new Point(14, 77);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(44, 15);
            lbl_cliente.TabIndex = 1;
            lbl_cliente.Text = "Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_new);
            panel2.Controls.Add(dgv_lista_pedidos);
            panel2.Location = new Point(15, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 271);
            panel2.TabIndex = 9;
            // 
            // btn_new
            // 
            btn_new.BackgroundImage = Properties.Resources.plus;
            btn_new.BackgroundImageLayout = ImageLayout.Stretch;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Location = new Point(822, 210);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(46, 46);
            btn_new.TabIndex = 12;
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // dgv_lista_pedidos
            // 
            dgv_lista_pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lista_pedidos.Location = new Point(17, 15);
            dgv_lista_pedidos.Name = "dgv_lista_pedidos";
            dgv_lista_pedidos.RowHeadersVisible = false;
            dgv_lista_pedidos.RowTemplate.Height = 25;
            dgv_lista_pedidos.Size = new Size(851, 189);
            dgv_lista_pedidos.TabIndex = 11;
            // 
            // GestionarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(910, 776);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "GestionarPedidos";
            Text = "GestionarPedidos";
            Load += GestionarPedidos_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_pedido).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_lista_pedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label lbl_title_pedidos;
        private Panel panel1;
        private Label lbl_cliente;
        private ComboBox cbx_clientes;
        private DataGridView dgv_pedido;
        private Label lbl_pedido;
        private Label lbl_cantidad;
        private TextBox txt_cantidad;
        private Label lbl_lista;
        private ComboBox cbx_lista;
        private DataGridView dgv_productos;
        private Panel panel2;
        private DataGridView dgv_lista_pedidos;
        private Button btn_new;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_save;
        private Label lbl_save;
        private Label lbl_facturar;
        private Button btn_bill;
        private Label lbl_fecha;
        private TextBox txt_fecha;
    }
}