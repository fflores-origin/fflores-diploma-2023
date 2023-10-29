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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPermisos));
            panel1 = new Panel();
            dgv_usuarios = new DataGridView();
            btn_add_family = new Button();
            btn_add_patente = new Button();
            lbl_family = new Label();
            lbl_patentes = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            lbl_users = new Label();
            panel2 = new Panel();
            lbl_permisos = new Label();
            treeView1 = new TreeView();
            panel3 = new Panel();
            btn_save = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgv_usuarios);
            panel1.Controls.Add(btn_add_family);
            panel1.Controls.Add(btn_add_patente);
            panel1.Controls.Add(lbl_family);
            panel1.Controls.Add(lbl_patentes);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(lbl_users);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 330);
            panel1.TabIndex = 0;
            // 
            // dgv_usuarios
            // 
            dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuarios.Location = new Point(23, 27);
            dgv_usuarios.Name = "dgv_usuarios";
            dgv_usuarios.RowTemplate.Height = 25;
            dgv_usuarios.Size = new Size(312, 137);
            dgv_usuarios.TabIndex = 9;
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
            // btn_add_patente
            // 
            btn_add_patente.Location = new Point(260, 197);
            btn_add_patente.Name = "btn_add_patente";
            btn_add_patente.Size = new Size(75, 23);
            btn_add_patente.TabIndex = 7;
            btn_add_patente.Text = "Agregar >";
            btn_add_patente.UseVisualStyleBackColor = true;
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
            // lbl_patentes
            // 
            lbl_patentes.AutoSize = true;
            lbl_patentes.Location = new Point(23, 180);
            lbl_patentes.Name = "lbl_patentes";
            lbl_patentes.Size = new Size(52, 15);
            lbl_patentes.TabIndex = 4;
            lbl_patentes.Text = "Patentes";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(23, 270);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(231, 23);
            comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(231, 23);
            comboBox2.TabIndex = 2;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_permisos);
            panel2.Controls.Add(treeView1);
            panel2.Location = new Point(383, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 330);
            panel2.TabIndex = 1;
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
            // treeView1
            // 
            treeView1.Location = new Point(19, 30);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(391, 273);
            treeView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_save);
            panel3.Location = new Point(12, 405);
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 51);
            panel4.TabIndex = 5;
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
            label4.Location = new Point(54, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "PERMISOS";
            // 
            // GestionarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(824, 514);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GestionarPermisos";
            Text = "Gestion Permisos";
            FormClosing += FormHide;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private DataGridView dgv_usuarios;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
    }
}