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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Txusuario.Clear();
            Txcontraseña.Clear();
        }

        private void btiniciosesion_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\TF049\Documents\clases cursos C#\InicioDeSesion\InicioDeSesion\bin\Debug\" + Txusuario.Text + ".txt", true);
                RegistrarUsuario.WriteLine(Txcontraseña.Text);
                RegistrarUsuario.Close();

                MessageBox.Show("Registrado correctamente");
            }
            catch (Exception x)
            {

                MessageBox.Show("Hubo un error" + x, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 vent = new Form1();
            vent.Show();
        }

        private void Txcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
