namespace PD.Presentation.Forms.Pedidos
{
    partial class GestionarClientes
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
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 51);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.client;
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
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "CLIENTES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(15, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 494);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 313);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(730, 213);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(644, 439);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // GestionarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(800, 599);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "GestionarClientes";
            Text = "GestionarClientes";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Panel panel1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
    }
}