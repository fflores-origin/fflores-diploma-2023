namespace PD.Presentation.Forms.Configuracion
{
    partial class GestionarIdiomas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarIdiomas));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.lbl_save = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_idioma = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_isoCode = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 51);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
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
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "IDIOMAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_isoCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.lbl_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.lbl_idioma);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txt_valor);
            this.panel1.Controls.Add(this.lbl_valor);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 393);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nuevo";
            // 
            // btn_new
            // 
            this.btn_new.BackgroundImage = global::PD.Presentation.Properties.Resources.plus1;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(204, 216);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(46, 46);
            this.btn_new.TabIndex = 15;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // lbl_save
            // 
            this.lbl_save.AutoSize = true;
            this.lbl_save.Location = new System.Drawing.Point(32, 265);
            this.lbl_save.Name = "lbl_save";
            this.lbl_save.Size = new System.Drawing.Size(49, 15);
            this.lbl_save.TabIndex = 14;
            this.lbl_save.Text = "Guardar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Eliminar";
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::PD.Presentation.Properties.Resources.cancel;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(118, 216);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(46, 46);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::PD.Presentation.Properties.Resources.save;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(32, 216);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(46, 46);
            this.btn_save.TabIndex = 10;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_idioma
            // 
            this.lbl_idioma.AutoSize = true;
            this.lbl_idioma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_idioma.Location = new System.Drawing.Point(289, 18);
            this.lbl_idioma.Name = "lbl_idioma";
            this.lbl_idioma.Size = new System.Drawing.Size(65, 21);
            this.lbl_idioma.TabIndex = 9;
            this.lbl_idioma.Text = "Idiomas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(434, 327);
            this.dataGridView1.TabIndex = 8;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(88, 120);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(163, 23);
            this.txt_valor.TabIndex = 4;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(23, 123);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(33, 15);
            this.lbl_valor.TabIndex = 4;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(88, 91);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(163, 23);
            this.txt_codigo.TabIndex = 3;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(23, 94);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Text = "Codigo";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(88, 62);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(163, 23);
            this.txt_id.TabIndex = 0;
            this.txt_id.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(23, 65);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 15);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 17;
            // 
            // lbl_isoCode
            // 
            this.lbl_isoCode.AutoSize = true;
            this.lbl_isoCode.Location = new System.Drawing.Point(22, 152);
            this.lbl_isoCode.Name = "lbl_isoCode";
            this.lbl_isoCode.Size = new System.Drawing.Size(50, 15);
            this.lbl_isoCode.TabIndex = 18;
            this.lbl_isoCode.Text = "IsoCode";
            // 
            // GestionarIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(765, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "GestionarIdiomas";
            this.Text = "GestionarIdiomas";
            this.Load += new System.EventHandler(this.GestionarIdiomas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private TextBox txt_id;
        private Label lbl_id;
        private TextBox txt_codigo;
        private Label lbl_codigo;
        private TextBox txt_valor;
        private Label lbl_valor;
        private DataGridView dataGridView1;
        private Label lbl_idioma;
        private Button btn_save;
        private Button btn_delete;
        private Label lbl_save;
        private Label label2;
        private Label label3;
        private Button btn_new;
        private TextBox textBox1;
        private Label lbl_isoCode;
    }
}