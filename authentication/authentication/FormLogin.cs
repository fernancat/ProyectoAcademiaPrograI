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
            String contraseña = contraseñaTxt.Text.ToString();
          DaoAuthentication authentication = new DaoAuthentication();

            bool logueo = authentication.LoguearUsuario(usuario, contraseña, this);
            if (logueo)
            {
                this.Hide();
                PantallaBienvenidacs pantallaBienvenida = new PantallaBienvenidacs();
                pantallaBienvenida.Show();
            }
        }
    }
}
