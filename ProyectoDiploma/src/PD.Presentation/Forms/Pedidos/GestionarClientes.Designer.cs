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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_tipo_cliente = new System.Windows.Forms.Label();
            this.cbx_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tipo_dni = new System.Windows.Forms.Label();
            this.txt_tipo_dni = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_help);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 51);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::PD.Presentation.Properties.Resources.client;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 45);
            this.panel5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "CLIENTES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 280);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(730, 240);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(623, 128);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 52);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 26);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(105, 23);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(251, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // lbl_cuit
            // 
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.Location = new System.Drawing.Point(21, 55);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(57, 15);
            this.lbl_cuit.TabIndex = 5;
            this.lbl_cuit.Text = "CUIT/DNI";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(105, 52);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(136, 23);
            this.txt_cuit.TabIndex = 4;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(21, 84);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.TabIndex = 7;
            this.lbl_direccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(105, 81);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(251, 23);
            this.txt_direccion.TabIndex = 6;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(408, 26);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(492, 23);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(251, 23);
            this.txt_email.TabIndex = 8;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(408, 55);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 15);
            this.lbl_telefono.TabIndex = 11;
            this.lbl_telefono.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(492, 52);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(251, 23);
            this.txt_telefono.TabIndex = 10;
            // 
            // lbl_tipo_cliente
            // 
            this.lbl_tipo_cliente.AutoSize = true;
            this.lbl_tipo_cliente.Location = new System.Drawing.Point(408, 84);
            this.lbl_tipo_cliente.Name = "lbl_tipo_cliente";
            this.lbl_tipo_cliente.Size = new System.Drawing.Size(30, 15);
            this.lbl_tipo_cliente.TabIndex = 13;
            this.lbl_tipo_cliente.Text = "Tipo";
            // 
            // cbx_tipo_cliente
            // 
            this.cbx_tipo_cliente.FormattingEnabled = true;
            this.cbx_tipo_cliente.Location = new System.Drawing.Point(492, 81);
            this.cbx_tipo_cliente.Name = "cbx_tipo_cliente";
            this.cbx_tipo_cliente.Size = new System.Drawing.Size(251, 23);
            this.cbx_tipo_cliente.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.lbl_tipo_dni);
            this.panel2.Controls.Add(this.txt_tipo_dni);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.cbx_tipo_cliente);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.lbl_tipo_cliente);
            this.panel2.Controls.Add(this.lbl_nombre);
            this.panel2.Controls.Add(this.lbl_telefono);
            this.panel2.Controls.Add(this.txt_cuit);
            this.panel2.Controls.Add(this.txt_telefono);
            this.panel2.Controls.Add(this.lbl_cuit);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Controls.Add(this.txt_direccion);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.lbl_direccion);
            this.panel2.Location = new System.Drawing.Point(12, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 202);
            this.panel2.TabIndex = 8;
            // 
            // lbl_tipo_dni
            // 
            this.lbl_tipo_dni.AutoSize = true;
            this.lbl_tipo_dni.Location = new System.Drawing.Point(247, 55);
            this.lbl_tipo_dni.Name = "lbl_tipo_dni";
            this.lbl_tipo_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_tipo_dni.TabIndex = 16;
            this.lbl_tipo_dni.Text = "Tipo";
            // 
            // txt_tipo_dni
            // 
            this.txt_tipo_dni.FormattingEnabled = true;
            this.txt_tipo_dni.Location = new System.Drawing.Point(283, 52);
            this.txt_tipo_dni.Name = "txt_tipo_dni";
            this.txt_tipo_dni.Size = new System.Drawing.Size(73, 23);
            this.txt_tipo_dni.TabIndex = 15;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(492, 128);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(120, 52);
            this.btn_nuevo.TabIndex = 17;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_help.Location = new System.Drawing.Point(729, 11);
            this.btn_help.Margin = new System.Windows.Forms.Padding(0);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(34, 32);
            this.btn_help.TabIndex = 18;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // GestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "GestionarClientes";
            this.Text = "GestionarClientes";
            this.Load += new System.EventHandler(this.GestionarClientes_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private Button btn_save;
        private DataGridView dataGridView1;
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
        private ComboBox txt_tipo_dni;
        private Label lbl_tipo_dni;
        private Button btn_nuevo;
        private Button btn_help;
    }
}