using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class DOOM : Form
    {
        public DOOM()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:\Users\al881\OneDrive\Documentos\ProyectoAcademiaPrograI\Info\Info\bin\Debug\Original-Doom-Gameplay-_Nightmare-Difficulty_.wmv";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
