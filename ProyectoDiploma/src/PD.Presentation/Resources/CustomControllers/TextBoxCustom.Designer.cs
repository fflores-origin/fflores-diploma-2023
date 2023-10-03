namespace PD.Presentation.Resources.CustomControllers
{
    partial class TextBoxCustom
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txt = new TextBox();
            pnl = new Panel();
            SuspendLayout();
            // 
            // txt
            // 
            txt.BorderStyle = BorderStyle.None;
            txt.Dock = DockStyle.Top;
            txt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt.Location = new Point(0, 0);
            txt.Name = "txt";
            txt.Size = new Size(383, 20);
            txt.TabIndex = 0;
            txt.Click += txt_OnClick;
            txt.Enter += txt_OnEnter;
            txt.KeyPress += txt_OnKeyPress;
            txt.Leave += txt_OnLeave;
            txt.MouseEnter += txt_OnMouseEnter;
            txt.MouseLeave += txt_OnMouseLeave;
            // 
            // pnl
            // 
            pnl.BackColor = SystemColors.ControlDarkDark;
            pnl.Dock = DockStyle.Bottom;
            pnl.Location = new Point(0, 29);
            pnl.Name = "pnl";
            pnl.Size = new Size(383, 1);
            pnl.TabIndex = 1;
            // 
            // TextBoxCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl);
            Controls.Add(txt);
            Name = "TextBoxCustom";
            Size = new Size(383, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private Panel pnl;
    }
}
