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
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            txt_isoCode = new TextBox();
            lbl_isoCode = new Label();
            label3 = new Label();
            btn_new = new Button();
            lbl_save = new Label();
            label2 = new Label();
            btn_delete = new Button();
            btn_save = new Button();
            lbl_idioma = new Label();
            dataGridView1 = new DataGridView();
            txt_valor = new TextBox();
            lbl_valor = new Label();
            txt_codigo = new TextBox();
            lbl_codigo = new Label();
            txt_id = new TextBox();
            lbl_id = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 51);
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
            label4.Text = "IDIOMAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_isoCode);
            panel1.Controls.Add(lbl_isoCode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_new);
            panel1.Controls.Add(lbl_save);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(lbl_idioma);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txt_valor);
            panel1.Controls.Add(lbl_valor);
            panel1.Controls.Add(txt_codigo);
            panel1.Controls.Add(lbl_codigo);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lbl_id);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 393);
            panel1.TabIndex = 6;
            // 
            // txt_isoCode
            // 
            txt_isoCode.Location = new Point(87, 149);
            txt_isoCode.Name = "txt_isoCode";
            txt_isoCode.Size = new Size(163, 23);
            txt_isoCode.TabIndex = 17;
            // 
            // lbl_isoCode
            // 
            lbl_isoCode.AutoSize = true;
            lbl_isoCode.Location = new Point(22, 152);
            lbl_isoCode.Name = "lbl_isoCode";
            lbl_isoCode.Size = new Size(50, 15);
            lbl_isoCode.TabIndex = 18;
            lbl_isoCode.Text = "IsoCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 265);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 16;
            label3.Text = "Nuevo";
            // 
            // btn_new
            // 
            btn_new.BackgroundImage = Properties.Resources.plus1;
            btn_new.BackgroundImageLayout = ImageLayout.Stretch;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Location = new Point(204, 216);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(46, 46);
            btn_new.TabIndex = 15;
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(32, 265);
            lbl_save.Name = "lbl_save";
            lbl_save.Size = new Size(49, 15);
            lbl_save.TabIndex = 14;
            lbl_save.Text = "Guardar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 265);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 13;
            label2.Text = "Eliminar";
            // 
            // btn_delete
            // 
            btn_delete.BackgroundImage = Properties.Resources.cancel;
            btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Location = new Point(118, 216);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(46, 46);
            btn_delete.TabIndex = 12;
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = Properties.Resources.save;
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(32, 216);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(46, 46);
            btn_save.TabIndex = 10;
            btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_idioma
            // 
            lbl_idioma.AutoSize = true;
            lbl_idioma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idioma.Location = new Point(289, 18);
            lbl_idioma.Name = "lbl_idioma";
            lbl_idioma.Size = new Size(65, 21);
            lbl_idioma.TabIndex = 9;
            lbl_idioma.Text = "Idiomas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(289, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(434, 327);
            dataGridView1.TabIndex = 8;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(88, 120);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(163, 23);
            txt_valor.TabIndex = 4;
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(23, 123);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(33, 15);
            lbl_valor.TabIndex = 4;
            lbl_valor.Text = "Valor";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(88, 91);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(163, 23);
            txt_codigo.TabIndex = 3;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Location = new Point(23, 94);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(46, 15);
            lbl_codigo.TabIndex = 2;
            lbl_codigo.Text = "Codigo";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(88, 62);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(163, 23);
            txt_id.TabIndex = 0;
            txt_id.TabStop = false;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(23, 65);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(18, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "ID";
            // 
            // GestionarIdiomas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(765, 474);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "GestionarIdiomas";
            Text = "GestionarIdiomas";
            Load += GestionarIdiomas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
        private TextBox txt_isoCode;
        private Label lbl_isoCode;
    }
}