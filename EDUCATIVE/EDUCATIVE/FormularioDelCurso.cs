using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EDUCATIVE
{
    public partial class FormularioDelCurso : Form
    {
        public FormularioDelCurso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btm_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btm_Maximizar.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ModificarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calificaciones_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Calificaciones.Height;
            SidePanel.Top = btn_Calificaciones.Top;


        }

        private void FormularioDelCurso_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void GetWindowLong();
        [DllImport("user32.DLL", EntryPoint = "SedMessage")]

        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int WParam);

        private void btn_Evaluaciones_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Tareas_Click(object sender, EventArgs e)
        {

        }

        private void btn_Retroalimentacion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Foros_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
