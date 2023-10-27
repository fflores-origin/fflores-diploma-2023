using Microsoft.Extensions.Configuration;

namespace PD.Presentation.Forms.Login
{
    public partial class Login : Form
    {
        private readonly Main _main;
        private readonly Recover _recover;
        private readonly IConfiguration _configuration;

        public Login(
            Main main,
            Recover recover,
            IConfiguration configuration)
        {
            InitializeComponent();
            _main = main;
            _recover = recover;
            _configuration = configuration;

            lbl_versionValue.Text = !string.IsNullOrEmpty(_configuration["Initial:Version"]) ? _configuration["Initial:Version"] : "1.0.0.0";
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
            _recover.ShowOverParent(this);
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