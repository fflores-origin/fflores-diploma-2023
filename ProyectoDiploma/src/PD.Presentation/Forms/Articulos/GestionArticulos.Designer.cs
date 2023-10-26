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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.pnl_seachbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_list = new System.Windows.Forms.Panel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1089, 46);
            this.pnl_head.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.dgv_articulos.Location = new System.Drawing.Point(42, 6);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.RowTemplate.Height = 25;
            this.dgv_articulos.Size = new System.Drawing.Size(1005, 577);
            this.dgv_articulos.TabIndex = 0;
            // 
            // pnl_seachbar
            // 
            this.pnl_seachbar.Controls.Add(this.button1);
            this.pnl_seachbar.Controls.Add(this.txt_search);
            this.pnl_seachbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_seachbar.Location = new System.Drawing.Point(0, 46);
            this.pnl_seachbar.Name = "pnl_seachbar";
            this.pnl_seachbar.Size = new System.Drawing.Size(1089, 53);
            this.pnl_seachbar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackgroundImage = global::PD.Presentation.Properties.Resources.seach;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1046, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(12, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(1065, 31);
            this.txt_search.TabIndex = 2;
            // 
            // pnl_list
            // 
            this.pnl_list.Controls.Add(this.pnl_buttons);
            this.pnl_list.Controls.Add(this.panel2);
            this.pnl_list.Controls.Add(this.panel1);
            this.pnl_list.Controls.Add(this.dgv_articulos);
            this.pnl_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_list.Location = new System.Drawing.Point(0, 99);
            this.pnl_list.Name = "pnl_list";
            this.pnl_list.Size = new System.Drawing.Size(1089, 689);
            this.pnl_list.TabIndex = 3;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.button2);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Location = new System.Drawing.Point(36, 589);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(1017, 100);
            this.pnl_buttons.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PD.Presentation.Properties.Resources.plus;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(934, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 76);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1053, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 689);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 689);
            this.panel1.TabIndex = 1;
            // 
            // GestionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 788);
            this.Controls.Add(this.pnl_list);
            this.Controls.Add(this.pnl_seachbar);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_head;
        private Label label1;
        private DataGridView dgv_articulos;
        private Panel pnl_seachbar;
        private Panel pnl_list;
        private Panel pnl_buttons;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private TextBox txt_search;
        private Button button2;
    }
}