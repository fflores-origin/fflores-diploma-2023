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
            pnl_head = new Panel();
            label1 = new Label();
            dgv_articulos = new DataGridView();
            pnl_seachbar = new Panel();
            button1 = new Button();
            txt_search = new TextBox();
            pnl_list = new Panel();
            pnl_buttons = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            lbl_add = new Label();
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
            pnl_head.Controls.Add(label1);
            pnl_head.Dock = DockStyle.Top;
            pnl_head.Location = new Point(0, 0);
            pnl_head.Name = "pnl_head";
            pnl_head.Size = new Size(1089, 54);
            pnl_head.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "ARTICULOS";
            // 
            // dgv_articulos
            // 
            dgv_articulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_articulos.Location = new Point(42, 6);
            dgv_articulos.Name = "dgv_articulos";
            dgv_articulos.RowTemplate.Height = 25;
            dgv_articulos.Size = new Size(1005, 569);
            dgv_articulos.TabIndex = 0;
            // 
            // pnl_seachbar
            // 
            pnl_seachbar.BackColor = Color.White;
            pnl_seachbar.Controls.Add(button1);
            pnl_seachbar.Controls.Add(txt_search);
            pnl_seachbar.Dock = DockStyle.Top;
            pnl_seachbar.Location = new Point(0, 54);
            pnl_seachbar.Name = "pnl_seachbar";
            pnl_seachbar.Size = new Size(1089, 53);
            pnl_seachbar.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1009, 10);
            button1.Name = "button1";
            button1.Padding = new Padding(6);
            button1.Size = new Size(31, 31);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            txt_search.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_search.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(42, 10);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(952, 31);
            txt_search.TabIndex = 2;
            // 
            // pnl_list
            // 
            pnl_list.Controls.Add(pnl_buttons);
            pnl_list.Controls.Add(panel2);
            pnl_list.Controls.Add(panel1);
            pnl_list.Controls.Add(dgv_articulos);
            pnl_list.Dock = DockStyle.Fill;
            pnl_list.Location = new Point(0, 107);
            pnl_list.Name = "pnl_list";
            pnl_list.Size = new Size(1089, 681);
            pnl_list.TabIndex = 3;
            // 
            // pnl_buttons
            // 
            pnl_buttons.Controls.Add(lbl_add);
            pnl_buttons.Controls.Add(button2);
            pnl_buttons.Dock = DockStyle.Bottom;
            pnl_buttons.Location = new Point(36, 581);
            pnl_buttons.Name = "pnl_buttons";
            pnl_buttons.Size = new Size(1017, 100);
            pnl_buttons.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(944, 14);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1053, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 681);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 681);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 45);
            panel5.TabIndex = 8;
            // 
            // lbl_add
            // 
            lbl_add.AutoSize = true;
            lbl_add.Location = new Point(952, 76);
            lbl_add.Name = "lbl_add";
            lbl_add.Size = new Size(49, 15);
            lbl_add.TabIndex = 1;
            lbl_add.Text = "Agregar";
            // 
            // GestionArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1089, 788);
            Controls.Add(pnl_list);
            Controls.Add(pnl_seachbar);
            Controls.Add(pnl_head);
            Name = "GestionArticulos";
            Text = "Articulos";
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
        private Panel panel5;
        private Label lbl_add;
    }
}