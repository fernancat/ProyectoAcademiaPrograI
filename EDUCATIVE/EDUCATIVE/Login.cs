using EDUCATIVE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SesionInicio
{
    public partial class Login : Form
    {
        private EDUCATIVE.DAOModels.auhentication autenticacion;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String UsuarioTexto = UsuarioTxt.Text.ToString();
            String ContraseñaTexto = ContraseñaTxt.Text.ToString();
            autenticacion = new EDUCATIVE.DAOModels.auhentication();
            EDUCATIVE.Models.Usuario usuarioLogueado = autenticacion.LoguearUsuario(UsuarioTexto, ContraseñaTexto, this);

            if (usuarioLogueado != null)
            {
                this.Hide();
                FormularioCargaCursos formularioCarga = new FormularioCargaCursos(usuarioLogueado);

                formularioCarga.Show();

            }
        }

        private void ContraseñaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
