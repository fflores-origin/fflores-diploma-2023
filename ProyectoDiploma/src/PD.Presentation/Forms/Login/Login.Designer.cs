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
            label1 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            label2 = new Label();
            btn_registro = new Button();
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
            btn_reset.Location = new Point(427, 345);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(289, 23);
            btn_reset.TabIndex = 4;
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
            btn_login.Location = new Point(427, 272);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(289, 50);
            btn_login.TabIndex = 3;
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
            btn_x.BackColor = Color.RosyBrown;
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
            panel1.BackColor = Color.FromArgb(215, 243, 251);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 447);
            panel1.TabIndex = 11;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.FromArgb(215, 243, 251);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(427, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 13;
            label1.Text = "Usuario";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(427, 107);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(289, 29);
            txt_user.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(427, 187);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(289, 29);
            txt_pass.TabIndex = 2;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(427, 163);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 15;
            label2.Text = "Contraseña";
            // 
            // btn_registro
            // 
            btn_registro.FlatAppearance.BorderSize = 0;
            btn_registro.FlatStyle = FlatStyle.Flat;
            btn_registro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_registro.ForeColor = Color.Gray;
            btn_registro.Location = new Point(427, 374);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(289, 23);
            btn_registro.TabIndex = 16;
            btn_registro.Text = "Registrarse";
            btn_registro.UseVisualStyleBackColor = true;
            btn_registro.Click += btn_registro_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 447);
            Controls.Add(btn_registro);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label label2;
        private Button btn_registro;
    }
}