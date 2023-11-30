namespace PD.Presentation.Forms.Pedidos
{
    partial class GestionarClientes
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
            btn_help = new Button();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            btn_nuevo = new Button();
            dgv_clientes = new DataGridView();
            btn_save = new Button();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            lbl_cuit = new Label();
            txt_cuit = new TextBox();
            lbl_direccion = new Label();
            txt_direccion = new TextBox();
            lbl_email = new Label();
            txt_email = new TextBox();
            lbl_telefono = new Label();
            txt_telefono = new TextBox();
            lbl_tipo_cliente = new Label();
            cbx_tipo_cliente = new ComboBox();
            panel2 = new Panel();
            lbl_tipo_dni = new Label();
            cbx_tipo_dni = new ComboBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_help);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 51);
            panel3.TabIndex = 6;
            // 
            // btn_help
            // 
            btn_help.BackgroundImage = Properties.Resources.light_bulb;
            btn_help.BackgroundImageLayout = ImageLayout.Stretch;
            btn_help.FlatAppearance.BorderSize = 0;
            btn_help.FlatStyle = FlatStyle.Flat;
            btn_help.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_help.Location = new Point(729, 11);
            btn_help.Margin = new Padding(0);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(34, 32);
            btn_help.TabIndex = 18;
            btn_help.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.client;
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
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "CLIENTES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_nuevo);
            panel1.Controls.Add(dgv_clientes);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 331);
            panel1.TabIndex = 7;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackgroundImage = Properties.Resources.plus1;
            btn_nuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btn_nuevo.FlatAppearance.BorderSize = 0;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Location = new Point(705, 265);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(46, 46);
            btn_nuevo.TabIndex = 17;
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // dgv_clientes
            // 
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Location = new Point(21, 19);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.RowTemplate.Height = 25;
            dgv_clientes.Size = new Size(730, 240);
            dgv_clientes.TabIndex = 2;
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = Properties.Resources.save;
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(697, 110);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(46, 46);
            btn_save.TabIndex = 3;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(21, 26);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(105, 23);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(251, 23);
            txt_nombre.TabIndex = 0;
            // 
            // lbl_cuit
            // 
            lbl_cuit.AutoSize = true;
            lbl_cuit.Location = new Point(21, 55);
            lbl_cuit.Name = "lbl_cuit";
            lbl_cuit.Size = new Size(57, 15);
            lbl_cuit.TabIndex = 5;
            lbl_cuit.Text = "CUIT/DNI";
            // 
            // txt_cuit
            // 
            txt_cuit.Location = new Point(105, 52);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(136, 23);
            txt_cuit.TabIndex = 4;
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Location = new Point(21, 84);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(57, 15);
            lbl_direccion.TabIndex = 7;
            lbl_direccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(105, 81);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(251, 23);
            txt_direccion.TabIndex = 6;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(408, 26);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 9;
            lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(492, 23);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(251, 23);
            txt_email.TabIndex = 8;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(408, 55);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(52, 15);
            lbl_telefono.TabIndex = 11;
            lbl_telefono.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(492, 52);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(251, 23);
            txt_telefono.TabIndex = 10;
            // 
            // lbl_tipo_cliente
            // 
            lbl_tipo_cliente.AutoSize = true;
            lbl_tipo_cliente.Location = new Point(408, 84);
            lbl_tipo_cliente.Name = "lbl_tipo_cliente";
            lbl_tipo_cliente.Size = new Size(30, 15);
            lbl_tipo_cliente.TabIndex = 13;
            lbl_tipo_cliente.Text = "Tipo";
            // 
            // cbx_tipo_cliente
            // 
            cbx_tipo_cliente.FormattingEnabled = true;
            cbx_tipo_cliente.Location = new Point(492, 81);
            cbx_tipo_cliente.Name = "cbx_tipo_cliente";
            cbx_tipo_cliente.Size = new Size(251, 23);
            cbx_tipo_cliente.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_tipo_dni);
            panel2.Controls.Add(cbx_tipo_dni);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(cbx_tipo_cliente);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(lbl_tipo_cliente);
            panel2.Controls.Add(lbl_nombre);
            panel2.Controls.Add(lbl_telefono);
            panel2.Controls.Add(txt_cuit);
            panel2.Controls.Add(txt_telefono);
            panel2.Controls.Add(lbl_cuit);
            panel2.Controls.Add(lbl_email);
            panel2.Controls.Add(txt_direccion);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(lbl_direccion);
            panel2.Location = new Point(15, 406);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 169);
            panel2.TabIndex = 8;
            // 
            // lbl_tipo_dni
            // 
            lbl_tipo_dni.AutoSize = true;
            lbl_tipo_dni.Location = new Point(247, 55);
            lbl_tipo_dni.Name = "lbl_tipo_dni";
            lbl_tipo_dni.Size = new Size(30, 15);
            lbl_tipo_dni.TabIndex = 16;
            lbl_tipo_dni.Text = "Tipo";
            // 
            // cbx_tipo_dni
            // 
            cbx_tipo_dni.FormattingEnabled = true;
            cbx_tipo_dni.Location = new Point(283, 52);
            cbx_tipo_dni.Name = "cbx_tipo_dni";
            cbx_tipo_dni.Size = new Size(73, 23);
            cbx_tipo_dni.TabIndex = 15;
            // 
            // GestionarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(800, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "GestionarClientes";
            Text = "GestionarClientes";
            Load += GestionarClientes_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private Button btn_save;
        private DataGridView dgv_clientes;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private Label lbl_cuit;
        private TextBox txt_cuit;
        private Label lbl_direccion;
        private TextBox txt_direccion;
        private Label lbl_telefono;
        private TextBox txt_telefono;
        private Label lbl_email;
        private TextBox txt_email;
        private Label lbl_tipo_cliente;
        private ComboBox cbx_tipo_cliente;
        private Panel panel2;
        private ComboBox cbx_tipo_dni;
        private Label lbl_tipo_dni;
        private Button btn_nuevo;
        private Button btn_help;
    }
}