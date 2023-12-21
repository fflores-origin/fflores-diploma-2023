namespace PD.Presentation.Forms.Configuracion
{
    partial class GestionarPatentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPatentes));
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            gb_nueva_patente = new GroupBox();
            btn_guardar_patente = new Button();
            lbl_nombre = new Label();
            txt_nombre_patente = new TextBox();
            lbl_permisos = new Label();
            cbx_permisos = new ComboBox();
            btn_agregar_patente = new Button();
            lbl_todas_patentes = new Label();
            cbx_patentes = new ComboBox();
            panel2 = new Panel();
            gb_nueva_familia = new GroupBox();
            btn_guardar_famila = new Button();
            label1 = new Label();
            txt_nombre_familia = new TextBox();
            btn_configurar = new Button();
            btn_agregar_familia = new Button();
            lbl_todas_familias = new Label();
            cbx_familias = new ComboBox();
            panel3 = new Panel();
            btn_guardar_todo = new Button();
            tw_permisos = new TreeView();
            lbl_title_permisos = new Label();
            button1 = new Button();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            gb_nueva_patente.SuspendLayout();
            panel2.SuspendLayout();
            gb_nueva_familia.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(722, 51);
            panel4.TabIndex = 6;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(gb_nueva_patente);
            panel1.Controls.Add(btn_agregar_patente);
            panel1.Controls.Add(lbl_todas_patentes);
            panel1.Controls.Add(cbx_patentes);
            panel1.Location = new Point(12, 358);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 343);
            panel1.TabIndex = 8;
            // 
            // gb_nueva_patente
            // 
            gb_nueva_patente.Controls.Add(btn_guardar_patente);
            gb_nueva_patente.Controls.Add(lbl_nombre);
            gb_nueva_patente.Controls.Add(txt_nombre_patente);
            gb_nueva_patente.Controls.Add(lbl_permisos);
            gb_nueva_patente.Controls.Add(cbx_permisos);
            gb_nueva_patente.Location = new Point(30, 129);
            gb_nueva_patente.Name = "gb_nueva_patente";
            gb_nueva_patente.Size = new Size(306, 176);
            gb_nueva_patente.TabIndex = 17;
            gb_nueva_patente.TabStop = false;
            gb_nueva_patente.Text = "Nueva";
            // 
            // btn_guardar_patente
            // 
            btn_guardar_patente.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar_patente.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_guardar_patente.FlatStyle = FlatStyle.Flat;
            btn_guardar_patente.Image = Properties.Resources.save_icon;
            btn_guardar_patente.Location = new Point(252, 129);
            btn_guardar_patente.Name = "btn_guardar_patente";
            btn_guardar_patente.Size = new Size(35, 35);
            btn_guardar_patente.TabIndex = 19;
            btn_guardar_patente.UseVisualStyleBackColor = true;
            btn_guardar_patente.Click += btn_guardar_patente_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(24, 81);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 20;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre_patente
            // 
            txt_nombre_patente.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre_patente.Location = new Point(24, 99);
            txt_nombre_patente.Name = "txt_nombre_patente";
            txt_nombre_patente.Size = new Size(263, 23);
            txt_nombre_patente.TabIndex = 19;
            // 
            // lbl_permisos
            // 
            lbl_permisos.AutoSize = true;
            lbl_permisos.Location = new Point(24, 29);
            lbl_permisos.Name = "lbl_permisos";
            lbl_permisos.Size = new Size(55, 15);
            lbl_permisos.TabIndex = 18;
            lbl_permisos.Text = "Permisos";
            // 
            // cbx_permisos
            // 
            cbx_permisos.FormattingEnabled = true;
            cbx_permisos.Location = new Point(24, 47);
            cbx_permisos.Name = "cbx_permisos";
            cbx_permisos.Size = new Size(263, 23);
            cbx_permisos.TabIndex = 18;
            // 
            // btn_agregar_patente
            // 
            btn_agregar_patente.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar_patente.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_agregar_patente.FlatStyle = FlatStyle.Flat;
            btn_agregar_patente.Image = Properties.Resources.angle_double_right;
            btn_agregar_patente.Location = new Point(276, 78);
            btn_agregar_patente.Name = "btn_agregar_patente";
            btn_agregar_patente.Size = new Size(35, 35);
            btn_agregar_patente.TabIndex = 17;
            btn_agregar_patente.UseVisualStyleBackColor = true;
            btn_agregar_patente.Click += btn_agregar_patente_Click;
            // 
            // lbl_todas_patentes
            // 
            lbl_todas_patentes.AutoSize = true;
            lbl_todas_patentes.Location = new Point(48, 29);
            lbl_todas_patentes.Name = "lbl_todas_patentes";
            lbl_todas_patentes.Size = new Size(52, 15);
            lbl_todas_patentes.TabIndex = 1;
            lbl_todas_patentes.Text = "Patentes";
            // 
            // cbx_patentes
            // 
            cbx_patentes.FormattingEnabled = true;
            cbx_patentes.Location = new Point(48, 47);
            cbx_patentes.Name = "cbx_patentes";
            cbx_patentes.Size = new Size(263, 23);
            cbx_patentes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(gb_nueva_familia);
            panel2.Controls.Add(btn_configurar);
            panel2.Controls.Add(btn_agregar_familia);
            panel2.Controls.Add(lbl_todas_familias);
            panel2.Controls.Add(cbx_familias);
            panel2.Location = new Point(12, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(358, 275);
            panel2.TabIndex = 9;
            // 
            // gb_nueva_familia
            // 
            gb_nueva_familia.Controls.Add(btn_guardar_famila);
            gb_nueva_familia.Controls.Add(label1);
            gb_nueva_familia.Controls.Add(txt_nombre_familia);
            gb_nueva_familia.Location = new Point(26, 122);
            gb_nueva_familia.Name = "gb_nueva_familia";
            gb_nueva_familia.Size = new Size(306, 128);
            gb_nueva_familia.TabIndex = 21;
            gb_nueva_familia.TabStop = false;
            gb_nueva_familia.Text = "Nueva";
            // 
            // btn_guardar_famila
            // 
            btn_guardar_famila.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar_famila.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_guardar_famila.FlatStyle = FlatStyle.Flat;
            btn_guardar_famila.Image = Properties.Resources.save_icon;
            btn_guardar_famila.Location = new Point(252, 80);
            btn_guardar_famila.Name = "btn_guardar_famila";
            btn_guardar_famila.Size = new Size(35, 35);
            btn_guardar_famila.TabIndex = 19;
            btn_guardar_famila.UseVisualStyleBackColor = true;
            btn_guardar_famila.Click += btn_guardar_famila_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // txt_nombre_familia
            // 
            txt_nombre_familia.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre_familia.Location = new Point(24, 50);
            txt_nombre_familia.Name = "txt_nombre_familia";
            txt_nombre_familia.Size = new Size(263, 23);
            txt_nombre_familia.TabIndex = 19;
            // 
            // btn_configurar
            // 
            btn_configurar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_configurar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_configurar.FlatStyle = FlatStyle.Flat;
            btn_configurar.Image = Properties.Resources.settings2;
            btn_configurar.Location = new Point(233, 78);
            btn_configurar.Name = "btn_configurar";
            btn_configurar.Size = new Size(35, 35);
            btn_configurar.TabIndex = 16;
            btn_configurar.UseVisualStyleBackColor = true;
            btn_configurar.Click += btn_configurar_Click;
            // 
            // btn_agregar_familia
            // 
            btn_agregar_familia.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar_familia.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_agregar_familia.FlatStyle = FlatStyle.Flat;
            btn_agregar_familia.Image = Properties.Resources.angle_double_right;
            btn_agregar_familia.Location = new Point(274, 78);
            btn_agregar_familia.Name = "btn_agregar_familia";
            btn_agregar_familia.Size = new Size(35, 35);
            btn_agregar_familia.TabIndex = 15;
            btn_agregar_familia.UseVisualStyleBackColor = true;
            btn_agregar_familia.Click += btn_agregar_familia_Click;
            // 
            // lbl_todas_familias
            // 
            lbl_todas_familias.AutoSize = true;
            lbl_todas_familias.Location = new Point(48, 29);
            lbl_todas_familias.Name = "lbl_todas_familias";
            lbl_todas_familias.Size = new Size(50, 15);
            lbl_todas_familias.TabIndex = 3;
            lbl_todas_familias.Text = "Familias";
            // 
            // cbx_familias
            // 
            cbx_familias.FormattingEnabled = true;
            cbx_familias.Location = new Point(48, 47);
            cbx_familias.Name = "cbx_familias";
            cbx_familias.Size = new Size(263, 23);
            cbx_familias.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lbl_title_permisos);
            panel3.Controls.Add(btn_guardar_todo);
            panel3.Controls.Add(tw_permisos);
            panel3.Location = new Point(376, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 632);
            panel3.TabIndex = 18;
            // 
            // btn_guardar_todo
            // 
            btn_guardar_todo.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar_todo.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_guardar_todo.FlatStyle = FlatStyle.Flat;
            btn_guardar_todo.Image = Properties.Resources.save_icon;
            btn_guardar_todo.Location = new Point(298, 577);
            btn_guardar_todo.Name = "btn_guardar_todo";
            btn_guardar_todo.Size = new Size(35, 35);
            btn_guardar_todo.TabIndex = 21;
            btn_guardar_todo.UseVisualStyleBackColor = true;
            // 
            // tw_permisos
            // 
            tw_permisos.Location = new Point(21, 47);
            tw_permisos.Name = "tw_permisos";
            tw_permisos.Size = new Size(312, 513);
            tw_permisos.TabIndex = 0;
            // 
            // lbl_title_permisos
            // 
            lbl_title_permisos.AutoSize = true;
            lbl_title_permisos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title_permisos.Location = new Point(21, 20);
            lbl_title_permisos.Name = "lbl_title_permisos";
            lbl_title_permisos.Size = new Size(129, 20);
            lbl_title_permisos.TabIndex = 22;
            lbl_title_permisos.Text = "Permisos y Grupos";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.interrogation;
            button1.Location = new Point(674, 9);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = true;
            // 
            // GestionarPatentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 716);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "GestionarPatentes";
            Load += GestionarPatentes_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gb_nueva_patente.ResumeLayout(false);
            gb_nueva_patente.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gb_nueva_familia.ResumeLayout(false);
            gb_nueva_familia.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_todas_patentes;
        private ComboBox cbx_patentes;
        private Label lbl_todas_familias;
        private ComboBox cbx_familias;
        private Button btn_agregar_familia;
        private Button btn_agregar_patente;
        private Button btn_configurar;
        private Panel panel3;
        private GroupBox gb_nueva_patente;
        private Label lbl_permisos;
        private ComboBox cbx_permisos;
        private Label lbl_nombre;
        private TextBox txt_nombre_patente;
        private Button btn_guardar_patente;
        private GroupBox gb_nueva_familia;
        private Button btn_guardar_famila;
        private Label label1;
        private TextBox txt_nombre_familia;
        private Button btn_guardar_todo;
        private TreeView tw_permisos;
        private Label lbl_title_permisos;
        private Button button1;
    }
}