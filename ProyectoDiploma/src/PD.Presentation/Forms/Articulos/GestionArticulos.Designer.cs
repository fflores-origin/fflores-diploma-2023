namespace PD.Presentation.Forms.Articulos
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.pnl_seachbar = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_list = new System.Windows.Forms.Panel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.lbl_add = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.pnl_seachbar.SuspendLayout();
            this.pnl_list.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.White;
            this.pnl_head.Controls.Add(this.panel5);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Location = new System.Drawing.Point(12, 12);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1065, 54);
            this.pnl_head.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 45);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARTICULOS";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Location = new System.Drawing.Point(22, 64);
            this.dgv_articulos.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.RowTemplate.Height = 25;
            this.dgv_articulos.Size = new System.Drawing.Size(1024, 355);
            this.dgv_articulos.TabIndex = 0;
            // 
            // pnl_seachbar
            // 
            this.pnl_seachbar.BackColor = System.Drawing.Color.White;
            this.pnl_seachbar.Controls.Add(this.btn_search);
            this.pnl_seachbar.Controls.Add(this.txt_search);
            this.pnl_seachbar.Location = new System.Drawing.Point(3, 3);
            this.pnl_seachbar.Name = "pnl_seachbar";
            this.pnl_seachbar.Size = new System.Drawing.Size(1059, 47);
            this.pnl_seachbar.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(959, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 31);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Buscar";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(19, 7);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(934, 31);
            this.txt_search.TabIndex = 2;
            // 
            // pnl_list
            // 
            this.pnl_list.BackColor = System.Drawing.Color.White;
            this.pnl_list.Controls.Add(this.dgv_articulos);
            this.pnl_list.Controls.Add(this.pnl_seachbar);
            this.pnl_list.Location = new System.Drawing.Point(12, 72);
            this.pnl_list.Name = "pnl_list";
            this.pnl_list.Size = new System.Drawing.Size(1065, 438);
            this.pnl_list.TabIndex = 3;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.White;
            this.pnl_buttons.Controls.Add(this.lbl_add);
            this.pnl_buttons.Controls.Add(this.button2);
            this.pnl_buttons.Location = new System.Drawing.Point(12, 516);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(1065, 100);
            this.pnl_buttons.TabIndex = 4;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Location = new System.Drawing.Point(991, 76);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(49, 15);
            this.lbl_add.TabIndex = 1;
            this.lbl_add.Text = "Agregar";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(983, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GestionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1089, 628);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.pnl_list);
            this.Controls.Add(this.pnl_head);
            this.Name = "GestionArticulos";
            this.Text = "Articulos";
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.pnl_seachbar.ResumeLayout(false);
            this.pnl_seachbar.PerformLayout();
            this.pnl_list.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Label label1;
        private DataGridView dgv_articulos;
        private Panel pnl_seachbar;
        private Panel pnl_list;
        private Panel pnl_buttons;
        private Button btn_search;
        private TextBox txt_search;
        private Button button2;
        private Panel panel5;
        private Label lbl_add;
    }
}