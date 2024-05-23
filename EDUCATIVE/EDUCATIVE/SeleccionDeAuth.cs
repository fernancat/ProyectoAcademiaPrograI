using INNICIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioDeSesion
{
    public partial class SeleccionDeAuth : Form
    {
        public SeleccionDeAuth()
        {
            FormularioPantallaDeCarga carga = new FormularioPantallaDeCarga();
            this.Hide();
            carga.Show();
            this.Show();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario ventanaUsuario = new RegistroUsuario();
            ventanaUsuario.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioS ventanaInicioSesion = new InicioS();
            
            ventanaInicioSesion.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
