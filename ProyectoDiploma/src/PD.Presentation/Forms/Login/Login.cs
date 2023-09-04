namespace PD.Presentation.Forms.Login
{
    public partial class Login : Form
    {
        private readonly Main _main;
        private readonly Recover _recover;

        public Login(
            Main main,
            Recover recover)
        {
            InitializeComponent();
            _main = main;
            _recover = recover;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            _main.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}