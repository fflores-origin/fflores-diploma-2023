namespace PD.Presentation.Forms.Configuracion
{
    partial class GestionarUsuariosPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarUsuariosPermisos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_add_family = new System.Windows.Forms.Button();
            this.btn_add_patente = new System.Windows.Forms.Button();
            this.lbl_family = new System.Windows.Forms.Label();
            this.lbl_patentes = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_users = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_permisos = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_save = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_usuarios);
            this.panel1.Controls.Add(this.btn_add_family);
            this.panel1.Controls.Add(this.btn_add_patente);
            this.panel1.Controls.Add(this.lbl_family);
            this.panel1.Controls.Add(this.lbl_patentes);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lbl_users);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 330);
            this.panel1.TabIndex = 0;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(23, 27);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowTemplate.Height = 25;
            this.dgv_usuarios.Size = new System.Drawing.Size(312, 136);
            this.dgv_usuarios.TabIndex = 9;
            // 
            // btn_add_family
            // 
            this.btn_add_family.Location = new System.Drawing.Point(260, 270);
            this.btn_add_family.Name = "btn_add_family";
            this.btn_add_family.Size = new System.Drawing.Size(75, 23);
            this.btn_add_family.TabIndex = 8;
            this.btn_add_family.Text = "Agregar >";
            this.btn_add_family.UseVisualStyleBackColor = true;
            // 
            // btn_add_patente
            // 
            this.btn_add_patente.Location = new System.Drawing.Point(260, 197);
            this.btn_add_patente.Name = "btn_add_patente";
            this.btn_add_patente.Size = new System.Drawing.Size(75, 24);
            this.btn_add_patente.TabIndex = 7;
            this.btn_add_patente.Text = "Agregar >";
            this.btn_add_patente.UseVisualStyleBackColor = true;
            // 
            // lbl_family
            // 
            this.lbl_family.AutoSize = true;
            this.lbl_family.Location = new System.Drawing.Point(23, 252);
            this.lbl_family.Name = "lbl_family";
            this.lbl_family.Size = new System.Drawing.Size(50, 15);
            this.lbl_family.TabIndex = 5;
            this.lbl_family.Text = "Familias";
            // 
            // lbl_patentes
            // 
            this.lbl_patentes.AutoSize = true;
            this.lbl_patentes.Location = new System.Drawing.Point(23, 180);
            this.lbl_patentes.Name = "lbl_patentes";
            this.lbl_patentes.Size = new System.Drawing.Size(52, 15);
            this.lbl_patentes.TabIndex = 4;
            this.lbl_patentes.Text = "Patentes";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(23, 270);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 23);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // lbl_users
            // 
            this.lbl_users.AutoSize = true;
            this.lbl_users.Location = new System.Drawing.Point(23, 9);
            this.lbl_users.Name = "lbl_users";
            this.lbl_users.Size = new System.Drawing.Size(52, 15);
            this.lbl_users.TabIndex = 1;
            this.lbl_users.Text = "Usuarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_permisos);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Location = new System.Drawing.Point(383, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 330);
            this.panel2.TabIndex = 1;
            // 
            // lbl_permisos
            // 
            this.lbl_permisos.AutoSize = true;
            this.lbl_permisos.Location = new System.Drawing.Point(19, 12);
            this.lbl_permisos.Name = "lbl_permisos";
            this.lbl_permisos.Size = new System.Drawing.Size(55, 15);
            this.lbl_permisos.TabIndex = 9;
            this.lbl_permisos.Text = "Permisos";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(19, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(391, 273);
            this.treeView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbl_save);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Location = new System.Drawing.Point(12, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 90);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 51);
            this.panel4.TabIndex = 5;
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
            this.label4.Location = new System.Drawing.Point(54, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "PERMISOS";
            // 
            // lbl_save
            // 
            this.lbl_save.AutoSize = true;
            this.lbl_save.Location = new System.Drawing.Point(734, 62);
            this.lbl_save.Name = "lbl_save";
            this.lbl_save.Size = new System.Drawing.Size(49, 15);
            this.lbl_save.TabIndex = 46;
            this.lbl_save.Text = "Guardar";
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(735, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(46, 46);
            this.btn_save.TabIndex = 45;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // GestionarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(824, 514);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestionarPermisos";
            this.Text = "Gestion Permisos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private DataGridView dgv_usuarios;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label lbl_save;
        private Button btn_save;
    }
}