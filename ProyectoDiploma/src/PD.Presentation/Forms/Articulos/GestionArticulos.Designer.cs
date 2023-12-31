﻿namespace PD.Presentation.Forms.Articulos
{
    partial class GestionArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionArticulos));
            pnl_head = new Panel();
            panel5 = new Panel();
            lbl_articulos_title = new Label();
            dgv_articulos = new DataGridView();
            pnl_seachbar = new Panel();
            btn_search = new Button();
            txt_search = new TextBox();
            pnl_list = new Panel();
            pnl_buttons = new Panel();
            lbl_imprimir_qr = new Label();
            btn_print_qrs = new Button();
            lbl_agregar = new Label();
            btn_add = new Button();
            pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_articulos).BeginInit();
            pnl_seachbar.SuspendLayout();
            pnl_list.SuspendLayout();
            pnl_buttons.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_head
            // 
            pnl_head.BackColor = Color.White;
            pnl_head.Controls.Add(panel5);
            pnl_head.Controls.Add(lbl_articulos_title);
            pnl_head.Location = new Point(12, 12);
            pnl_head.Name = "pnl_head";
            pnl_head.Size = new Size(1065, 54);
            pnl_head.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.newspaper;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 45);
            panel5.TabIndex = 8;
            // 
            // lbl_articulos_title
            // 
            lbl_articulos_title.AutoSize = true;
            lbl_articulos_title.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_articulos_title.Location = new Point(57, 10);
            lbl_articulos_title.Name = "lbl_articulos_title";
            lbl_articulos_title.Size = new Size(140, 32);
            lbl_articulos_title.TabIndex = 1;
            lbl_articulos_title.Text = "ARTICULOS";
            // 
            // dgv_articulos
            // 
            dgv_articulos.AllowUserToAddRows = false;
            dgv_articulos.AllowUserToDeleteRows = false;
            dgv_articulos.AllowUserToResizeColumns = false;
            dgv_articulos.AllowUserToResizeRows = false;
            dgv_articulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_articulos.BorderStyle = BorderStyle.None;
            dgv_articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_articulos.Location = new Point(22, 64);
            dgv_articulos.Margin = new Padding(10);
            dgv_articulos.Name = "dgv_articulos";
            dgv_articulos.RowTemplate.Height = 25;
            dgv_articulos.ScrollBars = ScrollBars.Vertical;
            dgv_articulos.Size = new Size(1024, 351);
            dgv_articulos.TabIndex = 0;
            // 
            // pnl_seachbar
            // 
            pnl_seachbar.BackColor = Color.White;
            pnl_seachbar.Controls.Add(btn_search);
            pnl_seachbar.Controls.Add(txt_search);
            pnl_seachbar.Location = new Point(3, 3);
            pnl_seachbar.Name = "pnl_seachbar";
            pnl_seachbar.Size = new Size(1059, 47);
            pnl_seachbar.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Left;
            btn_search.BackColor = Color.White;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleRight;
            btn_search.Location = new Point(959, 7);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(84, 31);
            btn_search.TabIndex = 3;
            btn_search.Text = "Buscar";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            txt_search.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_search.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(19, 7);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(934, 31);
            txt_search.TabIndex = 2;
            // 
            // pnl_list
            // 
            pnl_list.BackColor = Color.White;
            pnl_list.Controls.Add(dgv_articulos);
            pnl_list.Controls.Add(pnl_seachbar);
            pnl_list.Location = new Point(12, 72);
            pnl_list.Name = "pnl_list";
            pnl_list.Size = new Size(1065, 438);
            pnl_list.TabIndex = 3;
            // 
            // pnl_buttons
            // 
            pnl_buttons.BackColor = Color.White;
            pnl_buttons.Controls.Add(lbl_imprimir_qr);
            pnl_buttons.Controls.Add(btn_print_qrs);
            pnl_buttons.Controls.Add(lbl_agregar);
            pnl_buttons.Controls.Add(btn_add);
            pnl_buttons.Location = new Point(12, 516);
            pnl_buttons.Name = "pnl_buttons";
            pnl_buttons.Size = new Size(1065, 100);
            pnl_buttons.TabIndex = 4;
            // 
            // lbl_imprimir_qr
            // 
            lbl_imprimir_qr.AutoSize = true;
            lbl_imprimir_qr.Location = new Point(889, 76);
            lbl_imprimir_qr.Name = "lbl_imprimir_qr";
            lbl_imprimir_qr.Size = new Size(77, 15);
            lbl_imprimir_qr.TabIndex = 3;
            lbl_imprimir_qr.Text = "Imprimir QRs";
            // 
            // btn_print_qrs
            // 
            btn_print_qrs.BackgroundImage = Properties.Resources.printer;
            btn_print_qrs.BackgroundImageLayout = ImageLayout.Stretch;
            btn_print_qrs.FlatAppearance.BorderSize = 0;
            btn_print_qrs.FlatStyle = FlatStyle.Flat;
            btn_print_qrs.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_print_qrs.Location = new Point(896, 14);
            btn_print_qrs.Name = "btn_print_qrs";
            btn_print_qrs.Size = new Size(60, 60);
            btn_print_qrs.TabIndex = 2;
            btn_print_qrs.UseVisualStyleBackColor = true;
            btn_print_qrs.Click += btn_print_qrs_Click;
            // 
            // lbl_agregar
            // 
            lbl_agregar.AutoSize = true;
            lbl_agregar.Location = new Point(991, 76);
            lbl_agregar.Name = "lbl_agregar";
            lbl_agregar.Size = new Size(49, 15);
            lbl_agregar.TabIndex = 1;
            lbl_agregar.Text = "Agregar";
            // 
            // btn_add
            // 
            btn_add.BackgroundImage = Properties.Resources.plus1;
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(983, 14);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(60, 60);
            btn_add.TabIndex = 0;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // GestionArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1089, 628);
            Controls.Add(pnl_buttons);
            Controls.Add(pnl_list);
            Controls.Add(pnl_head);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionArticulos";
            Text = "Articulos";
            Load += GestionArticulos_Load;
            pnl_head.ResumeLayout(false);
            pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_articulos).EndInit();
            pnl_seachbar.ResumeLayout(false);
            pnl_seachbar.PerformLayout();
            pnl_list.ResumeLayout(false);
            pnl_buttons.ResumeLayout(false);
            pnl_buttons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_head;
        private Label lbl_articulos_title;
        private DataGridView dgv_articulos;
        private Panel pnl_seachbar;
        private Panel pnl_list;
        private Panel pnl_buttons;
        private Button btn_search;
        private TextBox txt_search;
        private Button btn_add;
        private Panel panel5;
        private Label lbl_agregar;
        private Label lbl_imprimir_qr;
        private Button btn_print_qrs;
    }
}