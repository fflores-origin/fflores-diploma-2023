﻿namespace PD.Presentation.Forms.Configuracion
{
    partial class GestionCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCategorias));
            panel3 = new Panel();
            panel5 = new Panel();
            lbl_title_categoria = new Label();
            panel1 = new Panel();
            dgv_list = new DataGridView();
            panel2 = new Panel();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            lbl_save = new Label();
            btn_save = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_list).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lbl_title_categoria);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 51);
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
            // lbl_title_categoria
            // 
            lbl_title_categoria.AutoSize = true;
            lbl_title_categoria.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title_categoria.Location = new Point(54, 11);
            lbl_title_categoria.Name = "lbl_title_categoria";
            lbl_title_categoria.Size = new Size(154, 32);
            lbl_title_categoria.TabIndex = 6;
            lbl_title_categoria.Text = "CATEGORIAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgv_list);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 209);
            panel1.TabIndex = 6;
            // 
            // dgv_list
            // 
            dgv_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_list.Location = new Point(12, 10);
            dgv_list.Margin = new Padding(10);
            dgv_list.Name = "dgv_list";
            dgv_list.RowTemplate.Height = 25;
            dgv_list.Size = new Size(437, 189);
            dgv_list.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_nombre);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(lbl_save);
            panel2.Controls.Add(btn_save);
            panel2.Location = new Point(12, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 136);
            panel2.TabIndex = 7;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(27, 18);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 18;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(27, 36);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(241, 23);
            txt_nombre.TabIndex = 17;
            // 
            // lbl_save
            // 
            lbl_save.AutoSize = true;
            lbl_save.Location = new Point(385, 105);
            lbl_save.Name = "lbl_save";
            lbl_save.Size = new Size(49, 15);
            lbl_save.TabIndex = 16;
            lbl_save.Text = "Guardar";
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = (Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(380, 36);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(60, 60);
            btn_save.TabIndex = 15;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // GestionCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(485, 436);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionCategorias";
            FormClosing += HideForm;
            Load += GestionCategorias_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_list).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label lbl_title_categoria;
        private Panel panel1;
        private DataGridView dgv_list;
        private Panel panel2;
        private Label lbl_save;
        private Button btn_save;
        private TextBox txt_nombre;
        private Label lbl_nombre;
    }
}