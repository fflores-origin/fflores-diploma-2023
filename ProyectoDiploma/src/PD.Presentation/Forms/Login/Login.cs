using Microsoft.Extensions.Configuration;
using PD.Core.Interfaces;
using PD.Entities;
using PD.Presentation.Helpers;
using PD.Services;
using PD.Services.Interfaces;
using System.Runtime.InteropServices;

namespace PD.Presentation.Forms.Login
{
    public partial class Login : Form, ILanguageObserver
    {
        private readonly Main _main;
        private readonly Recover _recover;
        private readonly IConfiguration _configuration;
        private readonly IUsuarioManager _usuarioManager;
        private readonly Sesion _sesion;
        private readonly IIdiomaManager _idiomaManager;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ClickMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Login(
            Main main,
            Recover recover,
            IConfiguration configuration,
            IUsuarioManager usuarioManager,
            IIdiomaManager idiomaManager)
        {
            InitializeComponent();
            this.Load += Login_Load;
            _main = main;
            _recover = recover;
            _configuration = configuration;
            _sesion = UserSesion.Session;

            lbl_versionValue.Text = !string.IsNullOrEmpty(_configuration["Initial:Version"]) ? _configuration["Initial:Version"] : "1.0.0.0";
            _usuarioManager = usuarioManager;
            _idiomaManager = idiomaManager;
        }

        private void Login_OnFormClosing(FormClosingEventArgs args)
        {
            Sesion.UnsubscribeObserver(this);
        }

        private void Login_Load(object? sender, EventArgs e)
        {
            Sesion.SubscribeObserver(this);
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

        private void Translate(Idioma? idioma = null)
        {
            var traducciones = _idiomaManager.GetTraducciones(idioma);

            this.TranslateForm(traducciones);

            this.Controls.TranslateAll(traducciones);
        }

        public void OnLanguageChanged(Idioma idioma)
        {
            Translate(idioma);
        }
    }
}