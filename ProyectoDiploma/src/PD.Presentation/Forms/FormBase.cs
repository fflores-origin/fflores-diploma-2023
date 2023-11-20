namespace PD.Presentation.Forms
{
    public class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormHide(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FormBase
            // 
            ClientSize = new Size(278, 244);
            Name = "FormBase";
            FormClosing += FormHide;
            ResumeLayout(false);
        }
    }
}