using login;

namespace authentication
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Loguear_Click(object sender, EventArgs e)
        {
            String usuario = usuarioTxt.Text.ToString();
            String contrase�a = contrase�aTxt.Text.ToString();
          DaoAuthentication authentication = new DaoAuthentication();

            bool logueo = authentication.LoguearUsuario(usuario, contrase�a, this);
            if (logueo)
            {
                this.Hide();
                PantallaBienvenidacs pantallaBienvenida = new PantallaBienvenidacs();
                pantallaBienvenida.Show();
            }
        }
    }
}
