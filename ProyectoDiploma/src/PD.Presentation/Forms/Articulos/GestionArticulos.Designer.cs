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
            pnl_head = new Panel();
            label1 = new Label();
            dgv_articulos = new DataGridView();
            pnl_seachbar = new Panel();
            button1 = new Button();
            txt_search = new TextBox();
            label2 = new Label();
            pnl_list = new Panel();
            pnl_buttons = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_articulos).BeginInit();
            pnl_seachbar.SuspendLayout();
            pnl_list.SuspendLayout();
            pnl_buttons.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_head
            // 
            pnl_head.BackColor = Color.FromArgb(224, 224, 224);
            pnl_head.Controls.Add(label1);
            pnl_head.Dock = DockStyle.Top;
            pnl_head.Location = new Point(0, 0);
            pnl_head.Name = "pnl_head";
            pnl_head.Size = new Size(1089, 46);
            pnl_head.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 1;
            label1.Text = "LISTADO";
            // 
            // dgv_articulos
            // 
            dgv_articulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_articulos.Location = new Point(42, 6);
            dgv_articulos.Name = "dgv_articulos";
            dgv_articulos.RowTemplate.Height = 25;
            dgv_articulos.Size = new Size(1005, 577);
            dgv_articulos.TabIndex = 0;
            // 
            // pnl_seachbar
            // 
            pnl_seachbar.Controls.Add(button1);
            pnl_seachbar.Controls.Add(txt_search);
            pnl_seachbar.Controls.Add(label2);
            pnl_seachbar.Dock = DockStyle.Top;
            pnl_seachbar.Location = new Point(0, 46);
            pnl_seachbar.Name = "pnl_seachbar";
            pnl_seachbar.Size = new Size(1089, 53);
            pnl_seachbar.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(1037, 6);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 3;
            button1.Text = "Q";
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_search.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(63, 10);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(968, 31);
            txt_search.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            // 
            // pnl_list
            // 
            pnl_list.Controls.Add(pnl_buttons);
            pnl_list.Controls.Add(panel2);
            pnl_list.Controls.Add(panel1);
            pnl_list.Controls.Add(dgv_articulos);
            pnl_list.Dock = DockStyle.Fill;
            pnl_list.Location = new Point(0, 99);
            pnl_list.Name = "pnl_list";
            pnl_list.Size = new Size(1089, 689);
            pnl_list.TabIndex = 3;
            // 
            // pnl_buttons
            // 
            pnl_buttons.Controls.Add(button2);
            pnl_buttons.Dock = DockStyle.Bottom;
            pnl_buttons.Location = new Point(36, 589);
            pnl_buttons.Name = "pnl_buttons";
            pnl_buttons.Size = new Size(1017, 100);
            pnl_buttons.TabIndex = 4;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(930, 12);
            button2.Name = "button2";
            button2.Size = new Size(77, 76);
            button2.TabIndex = 0;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1053, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 689);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 689);
            panel1.TabIndex = 1;
            // 
            // GestionArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 788);
            Controls.Add(pnl_list);
            Controls.Add(pnl_seachbar);
            Controls.Add(pnl_head);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_head;
        private Label label1;
        private DataGridView dgv_articulos;
        private Panel pnl_seachbar;
        private Panel pnl_list;
        private Label label2;
        private Panel pnl_buttons;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private TextBox txt_search;
        private Button button2;
    }
}