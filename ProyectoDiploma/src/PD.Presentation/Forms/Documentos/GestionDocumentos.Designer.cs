namespace PD.Presentation.Forms.Documentos
{
    partial class GestionDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDocumentos));
            panel3 = new Panel();
            panel5 = new Panel();
            lbl_title_categoria = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_save = new Button();
            btn_new = new Button();
            dataGridView2 = new DataGridView();
            textBox2 = new TextBox();
            lbl_total = new Label();
            textBox3 = new TextBox();
            lbl_pedido = new Label();
            lbl_iva = new Label();
            textBox4 = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lbl_title_categoria);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 51);
            panel3.TabIndex = 6;
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
            // lbl_title_categoria
            // 
            lbl_title_categoria.AutoSize = true;
            lbl_title_categoria.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title_categoria.Location = new Point(54, 11);
            lbl_title_categoria.Name = "lbl_title_categoria";
            lbl_title_categoria.Size = new Size(168, 32);
            lbl_title_categoria.TabIndex = 6;
            lbl_title_categoria.Text = "FACTURACION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_new);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 329);
            panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 237);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_iva);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(lbl_pedido);
            panel2.Controls.Add(lbl_total);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_save);
            panel2.Location = new Point(12, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 352);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 84);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(101, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Número";
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = Properties.Resources.save;
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(704, 292);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(46, 46);
            btn_save.TabIndex = 0;
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            btn_new.BackgroundImage = Properties.Resources.plus;
            btn_new.BackgroundImageLayout = ImageLayout.Stretch;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Location = new Point(704, 267);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(46, 46);
            btn_new.TabIndex = 13;
            btn_new.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(392, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(358, 259);
            dataGridView2.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(101, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 23);
            textBox2.TabIndex = 15;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(23, 204);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(32, 15);
            lbl_total.TabIndex = 16;
            lbl_total.Text = "Total";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(101, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 23);
            textBox3.TabIndex = 18;
            // 
            // lbl_pedido
            // 
            lbl_pedido.AutoSize = true;
            lbl_pedido.Location = new Point(19, 55);
            lbl_pedido.Name = "lbl_pedido";
            lbl_pedido.Size = new Size(44, 15);
            lbl_pedido.TabIndex = 17;
            lbl_pedido.Text = "Pedido";
            // 
            // lbl_iva
            // 
            lbl_iva.AutoSize = true;
            lbl_iva.Location = new Point(23, 233);
            lbl_iva.Name = "lbl_iva";
            lbl_iva.Size = new Size(22, 15);
            lbl_iva.TabIndex = 20;
            lbl_iva.Text = "Iva";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(101, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 23);
            textBox4.TabIndex = 19;
            // 
            // GestionDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(800, 768);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionDocumentos";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label lbl_title_categoria;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button btn_save;
        private Label label2;
        private ComboBox comboBox1;
        private Button btn_new;
        private DataGridView dataGridView2;
        private Label lbl_total;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbl_pedido;
        private Label lbl_iva;
        private TextBox textBox4;
    }
}