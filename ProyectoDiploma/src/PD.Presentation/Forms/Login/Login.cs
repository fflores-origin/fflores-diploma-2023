using Microsoft.Extensions.Configuration;
using PD.Core.Interfaces;
using PD.Presentation.Helpers;
using PD.Services;
using System.Runtime.InteropServices;

namespace PD.Presentation.Forms.Login
{
    public partial class Login : Form
    {
        private readonly Main _main;
        private readonly Recover _recover;
        private readonly IConfiguration _configuration;
        private readonly IUsuarioManager _usuarioManager;
        private readonly Sesion _sesion;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void ClickMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Login(
            Main main,
            Recover recover,
            IConfiguration configuration,
            IUsuarioManager usuarioManager)
        {
            InitializeComponent();
            _main = main;
            _recover = recover;
            _configuration = configuration;
            _sesion = UserSesion.Session;

            lbl_versionValue.Text = !string.IsNullOrEmpty(_configuration["Initial:Version"]) ? _configuration["Initial:Version"] : "1.0.0.0";
            _usuarioManager = usuarioManager;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.IsTextInvalid())
            {
                MessageBox.Show("Usuario no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_pass.IsTextInvalid())
            {
                MessageBox.Show("Password no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var userStatus = _usuarioManager.Login(txt_user.Text, txt_pass.Text);

            switch (userStatus)
            {
                case Services.Enums.LoginResult.InvalidUsername:
                    MessageBox.Show("Usuario Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                case Services.Enums.LoginResult.InvalidPassword:
                    MessageBox.Show("Password Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                case Services.Enums.LoginResult.ValidUser:
                    MessageBox.Show($"Bienvenido {txt_user.Text}");
                    break;

                default:
                    MessageBox.Show("Ah ocurrido un error interno por favor intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

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

        private void btn_registro_Click(object sender, EventArgs e)
        {
            _usuarioManager.CrearUsuario("admin", "Novedad.01");
        }
    }
}