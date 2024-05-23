using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InicioDeSesion
{
    public partial class InicioS : Form
    {
        public InicioS()
        {
            InitializeComponent();
        }

        private void acceder_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader Inicio = new StreamReader(Txusuario.Text + ".txt");
                if (Inicio.ReadLine() == Txcontraseña.Text)
                {
                    MessageBox.Show("Se Inicio Sesion");
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesion");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un error" + x, "Error");

            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Txcontraseña.Clear();
            Txusuario.Clear();
        }

        private void InicioS_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionDeAuth ventan = new SeleccionDeAuth();
            ventan.Show();
        }
    }
}
