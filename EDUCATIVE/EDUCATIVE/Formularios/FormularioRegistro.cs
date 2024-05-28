using EDUCATIVE;
using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;
using SesionInicio;

namespace registro1
{
    public partial class FormularioRegistro : Form
    {
        private EDUCATIVE.DAOModels.auhentication autenticacion;

        public FormularioRegistro()
        {
            InitializeComponent();
        }


        public void confitmar_Click(object sender, EventArgs e)
        {
            string txtNombre = nombres.Text;
            string txtApellidos = apellidos.Text;
            string txtCorreo = correo.Text;
            string txtcontraseña = contra.Text;
            string txtConfirmarContraseña = concontra.Text;

            if (string.IsNullOrWhiteSpace(txtNombre) ||
            string.IsNullOrWhiteSpace(txtApellidos) ||
            string.IsNullOrWhiteSpace(txtCorreo) ||
            string.IsNullOrWhiteSpace(txtcontraseña) ||
            string.IsNullOrWhiteSpace(txtConfirmarContraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios y no pueden estar vacíos.");
                return;
            }
            else
            {
                if (txtcontraseña.Equals(txtConfirmarContraseña))
                {
                    if (maestro.Checked && Estudiante.Checked) {
                        MessageBox.Show("No puedes marcar las dos opciones, solo selecciona una");
                    }
                    else
                    {
                        //rol seleccionado maestro
                        if (maestro.Checked)
                        {
                            autenticacion = new auhentication();
                            Usuario usuario = autenticacion.registrarUsuario(txtNombre,txtApellidos, txtCorreo,txtcontraseña,"Maestro");
                            if (usuario!= null)
                            {
                                this.Hide();
                                FormularioCargaCursos formulario = new FormularioCargaCursos(usuario);
                                formulario.Show();

                            }


                        }
                        //rol seleccionado alumno
                        else if (Estudiante.Checked)
                        {
                           autenticacion = new auhentication();
                           Usuario usuario = autenticacion.registrarUsuario(txtNombre, txtApellidos, txtCorreo, txtcontraseña, "Estudiante");
                            if (usuario != null)
                            {
                                this.Hide();
                                FormularioCargaCursos formulario = new FormularioCargaCursos(usuario);
                                formulario.Show();

                            }
                            else
                            {
                                MessageBox.Show("no has seleccionado ninguna de las opciones disponibles");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñaas indicadas no coinciden");
                }
            }

        }

        public void regresar_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

    }
}
