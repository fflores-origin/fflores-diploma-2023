namespace PD.Presentation.Forms.Articulos
{
    partial class GestionListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionListas));
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            btn_add = new Button();
            lbl_producto = new Label();
            lbl_listas = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 51);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 6;
            label4.Text = "LISTAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_listas);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 208);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(351, 104);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_producto);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(12, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 378);
            panel2.TabIndex = 7;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 44);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(351, 281);
            dataGridView2.TabIndex = 0;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(307, 157);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(67, 31);
            btn_add.TabIndex = 1;
            btn_add.Text = "Agregar";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_producto
            // 
            lbl_producto.AutoSize = true;
            lbl_producto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_producto.Location = new Point(23, 11);
            lbl_producto.Name = "lbl_producto";
            lbl_producto.Size = new Size(80, 21);
            lbl_producto.TabIndex = 13;
            lbl_producto.Text = "Productos";
            // 
            // lbl_listas
            // 
            lbl_listas.AutoSize = true;
            lbl_listas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_listas.Location = new Point(22, 11);
            lbl_listas.Name = "lbl_listas";
            lbl_listas.Size = new Size(49, 21);
            lbl_listas.TabIndex = 14;
            lbl_listas.Text = "Listas";
            // 
            // GestionListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(427, 695);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "GestionListas";
            Text = "GestionListas";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Button btn_add;
        private Label lbl_producto;
        private Label lbl_listas;
    }
}