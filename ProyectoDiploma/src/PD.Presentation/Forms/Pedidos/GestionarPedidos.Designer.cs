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
            label4 = new Label();
            panel1 = new Panel();
            btn_save = new Button();
            btn_remove = new Button();
            btn_add = new Button();
            lbl_lista = new Label();
            comboBox2 = new ComboBox();
            dgv_productos = new DataGridView();
            lbl_cantidad = new Label();
            textBox1 = new TextBox();
            lbl_pedido = new Label();
            dgv_pedido = new DataGridView();
            comboBox1 = new ComboBox();
            lbl_cliente = new Label();
            panel2 = new Panel();
            btn_new = new Button();
            dgv_lista_pedidos = new DataGridView();
            lbl_save = new Label();
            btn_bill = new Button();
            label1 = new Label();
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
            panel3.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 6;
            label4.Text = "PEDIDOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_bill);
            panel1.Controls.Add(lbl_save);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_remove);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(lbl_lista);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(dgv_productos);
            panel1.Controls.Add(lbl_cantidad);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbl_pedido);
            panel1.Controls.Add(dgv_pedido);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lbl_cliente);
            panel1.Location = new Point(15, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 418);
            panel1.TabIndex = 8;
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
            btn_remove.Location = new Point(461, 313);
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
            btn_add.Location = new Point(383, 313);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(46, 46);
            btn_add.TabIndex = 13;
            btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_lista
            // 
            lbl_lista.AutoSize = true;
            lbl_lista.Location = new Point(33, 90);
            lbl_lista.Name = "lbl_lista";
            lbl_lista.Size = new Size(31, 15);
            lbl_lista.TabIndex = 10;
            lbl_lista.Text = "Lista";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(114, 87);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(315, 23);
            comboBox2.TabIndex = 9;
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Location = new Point(33, 136);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowTemplate.Height = 25;
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos.Size = new Size(396, 142);
            dgv_productos.TabIndex = 8;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(198, 287);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(55, 15);
            lbl_cantidad.TabIndex = 7;
            lbl_cantidad.Text = "Cantidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 6;
            // 
            // lbl_pedido
            // 
            lbl_pedido.AutoSize = true;
            lbl_pedido.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pedido.Location = new Point(461, 38);
            lbl_pedido.Name = "lbl_pedido";
            lbl_pedido.Size = new Size(67, 25);
            lbl_pedido.TabIndex = 5;
            lbl_pedido.Text = "Pedido";
            // 
            // dgv_pedido
            // 
            dgv_pedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pedido.Location = new Point(461, 66);
            dgv_pedido.Name = "dgv_pedido";
            dgv_pedido.RowTemplate.Height = 25;
            dgv_pedido.Size = new Size(396, 241);
            dgv_pedido.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 23);
            comboBox1.TabIndex = 2;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Location = new Point(33, 61);
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
            btn_new.Location = new Point(811, 210);
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
            dgv_lista_pedidos.RowTemplate.Height = 25;
            dgv_lista_pedidos.Size = new Size(840, 189);
            dgv_lista_pedidos.TabIndex = 11;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(743, 387);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 18;
            label1.Text = "Facturar";
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
        private Label label4;
        private Panel panel1;
        private Label lbl_cliente;
        private ComboBox comboBox1;
        private DataGridView dgv_pedido;
        private Label lbl_pedido;
        private Label lbl_cantidad;
        private TextBox textBox1;
        private Label lbl_lista;
        private ComboBox comboBox2;
        private DataGridView dgv_productos;
        private Panel panel2;
        private DataGridView dgv_lista_pedidos;
        private Button btn_new;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_save;
        private Label lbl_save;
        private Label label1;
        private Button btn_bill;
    }
}