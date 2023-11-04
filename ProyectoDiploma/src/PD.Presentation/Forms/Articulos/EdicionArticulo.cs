using PD.Presentation.Helpers;

namespace PD.Presentation.Forms.Articulos
{
    public partial class EdicionArticulo : FormBase
    {
        public EdicionArticulo() : base()
        {
            InitializeComponent();
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_nombre.IsTextInvalid())
            {
                MessageBox.Show("Nombre no puede quedar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btn_image_change_Click(object sender, EventArgs e)
        {

        }
    }
}