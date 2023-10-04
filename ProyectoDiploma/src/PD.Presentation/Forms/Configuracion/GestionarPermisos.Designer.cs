namespace PD.Presentation.Forms.Configuracion
{
    partial class GestionarPermisos
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
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_users = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            lbl_patentes = new Label();
            lbl_family = new Label();
            btn_add_patente = new Button();
            btn_add_family = new Button();
            treeView1 = new TreeView();
            lbl_permisos = new Label();
            panel3 = new Panel();
            btn_save = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btn_add_family);
            panel1.Controls.Add(btn_add_patente);
            panel1.Controls.Add(lbl_family);
            panel1.Controls.Add(lbl_patentes);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(lbl_users);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 330);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_permisos);
            panel2.Controls.Add(treeView1);
            panel2.Location = new Point(383, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 330);
            panel2.TabIndex = 1;
            // 
            // lbl_users
            // 
            lbl_users.AutoSize = true;
            lbl_users.Location = new Point(23, 9);
            lbl_users.Name = "lbl_users";
            lbl_users.Size = new Size(52, 15);
            lbl_users.TabIndex = 1;
            lbl_users.Text = "Usuarios";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(231, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(23, 270);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(231, 23);
            comboBox3.TabIndex = 3;
            // 
            // lbl_patentes
            // 
            lbl_patentes.AutoSize = true;
            lbl_patentes.Location = new Point(23, 180);
            lbl_patentes.Name = "lbl_patentes";
            lbl_patentes.Size = new Size(52, 15);
            lbl_patentes.TabIndex = 4;
            lbl_patentes.Text = "Patentes";
            // 
            // lbl_family
            // 
            lbl_family.AutoSize = true;
            lbl_family.Location = new Point(23, 252);
            lbl_family.Name = "lbl_family";
            lbl_family.Size = new Size(50, 15);
            lbl_family.TabIndex = 5;
            lbl_family.Text = "Familias";
            // 
            // btn_add_patente
            // 
            btn_add_patente.Location = new Point(260, 197);
            btn_add_patente.Name = "btn_add_patente";
            btn_add_patente.Size = new Size(75, 23);
            btn_add_patente.TabIndex = 7;
            btn_add_patente.Text = "Agregar >";
            btn_add_patente.UseVisualStyleBackColor = true;
            // 
            // btn_add_family
            // 
            btn_add_family.Location = new Point(260, 270);
            btn_add_family.Name = "btn_add_family";
            btn_add_family.Size = new Size(75, 23);
            btn_add_family.TabIndex = 8;
            btn_add_family.Text = "Agregar >";
            btn_add_family.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(19, 30);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(391, 273);
            treeView1.TabIndex = 0;
            // 
            // lbl_permisos
            // 
            lbl_permisos.AutoSize = true;
            lbl_permisos.Location = new Point(19, 12);
            lbl_permisos.Name = "lbl_permisos";
            lbl_permisos.Size = new Size(55, 15);
            lbl_permisos.TabIndex = 9;
            lbl_permisos.Text = "Permisos";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_save);
            panel3.Location = new Point(12, 348);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 90);
            panel3.TabIndex = 2;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(641, 26);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(140, 40);
            btn_save.TabIndex = 0;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(312, 137);
            dataGridView1.TabIndex = 9;
            // 
            // GestionarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GestionarPermisos";
            Text = "Gestion Permisos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_family;
        private Label lbl_patentes;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label lbl_users;
        private Panel panel2;
        private Button btn_add_family;
        private Button btn_add_patente;
        private Label lbl_permisos;
        private TreeView treeView1;
        private Panel panel3;
        private Button btn_save;
        private DataGridView dataGridView1;
    }
}