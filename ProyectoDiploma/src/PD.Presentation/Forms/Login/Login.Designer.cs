namespace PD.Presentation.Forms.Login
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            btn_reset = new Button();
            btn_login = new Button();
            lbl_version = new Label();
            lbl_versionValue = new Label();
            pictureBox1 = new PictureBox();
            btn_x = new Button();
            panel1 = new Panel();
            btn_minimize = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_reset
            // 
            btn_reset.FlatAppearance.BorderSize = 0;
            btn_reset.FlatStyle = FlatStyle.Flat;
            btn_reset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_reset.ForeColor = Color.Gray;
            btn_reset.Location = new Point(497, 345);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(150, 23);
            btn_reset.TabIndex = 0;
            btn_reset.Text = "¿ Olvidaste tu contraseña ?";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.MidnightBlue;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(427, 260);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(289, 50);
            btn_login.TabIndex = 5;
            btn_login.Text = "ACCEDER";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_version
            // 
            lbl_version.AutoSize = true;
            lbl_version.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_version.Location = new Point(499, 414);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new Size(52, 17);
            lbl_version.TabIndex = 7;
            lbl_version.Text = "Version";
            // 
            // lbl_versionValue
            // 
            lbl_versionValue.AutoSize = true;
            lbl_versionValue.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_versionValue.Location = new Point(597, 414);
            lbl_versionValue.Name = "lbl_versionValue";
            lbl_versionValue.Size = new Size(43, 17);
            lbl_versionValue.TabIndex = 8;
            lbl_versionValue.Text = "1.0.0.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stock1;
            pictureBox1.Location = new Point(42, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_x
            // 
            btn_x.BackColor = Color.White;
            btn_x.FlatAppearance.BorderSize = 0;
            btn_x.FlatStyle = FlatStyle.Flat;
            btn_x.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_x.Location = new Point(762, 12);
            btn_x.Name = "btn_x";
            btn_x.Size = new Size(36, 36);
            btn_x.TabIndex = 10;
            btn_x.Text = "X";
            btn_x.UseVisualStyleBackColor = false;
            btn_x.Click += btn_x_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 447);
            panel1.TabIndex = 11;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.White;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_minimize.Location = new Point(720, 12);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(36, 36);
            btn_minimize.TabIndex = 12;
            btn_minimize.Text = "_";
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
           
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 447);
            Controls.Add(btn_minimize);
            Controls.Add(panel1);
            Controls.Add(btn_x);
            Controls.Add(lbl_versionValue);
            Controls.Add(lbl_version);
            Controls.Add(btn_login);
            Controls.Add(btn_reset);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_reset;
        private Button btn_login;
        private Label lbl_version;
        private Label lbl_versionValue;
        private PictureBox pictureBox1;
        private Button btn_x;
        private Panel panel1;
        private Button btn_minimize;
        private ContextMenuStrip contextMenuStrip1;
    }
}