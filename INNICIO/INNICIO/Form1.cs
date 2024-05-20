using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace INNICIO
{
    public partial class Form1 : Form
    {


        private System.Windows.Forms.Timer progressBarTimer;
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            InitializeProgressBarTimer();
            CustomizeProgressBarColor();




            soundPlayer = new SoundPlayer(@"C:\Users\al881\ProyectoAcademiaPrograI\INNICIO\INNICIO\music.wav");
            soundPlayer.Play();
        }
        private void CustomizeProgressBarColor()
        {
            // Cambia el color de la barra de progreso
            progressBar1.ForeColor = Color.Blue;

            // Configura el estilo de la barra de progreso (opcional)
            progressBar1.Style = ProgressBarStyle.Continuous; // O ProgressBarStyle.Marquee si es indeterminada
        }

        private void InitializeProgressBarTimer()
        {
            progressBarTimer = new System.Windows.Forms.Timer();
            progressBarTimer.Interval = 70; // Intervalo en milisegundos (ajústalo según tu preferencia)
            progressBarTimer.Tick += ProgressBarTimer_Tick;
            progressBarTimer.Start();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1; // Incremento ajustado a 1 para una carga más rápida
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                progressBarTimer.Stop();
                soundPlayer.Stop(); // Detener la reproducción al finalizar la carga
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // URL que deseas abrir en el navegador
            string url = "https://umg.edu.gt/miumg/";

            try
            {
                // Configura la información de inicio del proceso
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                // Abre el enlace en el navegador predeterminado del sistema
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que ocurra al abrir el enlace
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/u.marianogalvez/";

            try
            {
                // Configura la información de inicio del proceso
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                // Abre el enlace en el navegador predeterminado del sistema
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que ocurra al abrir el enlace
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://youtu.be/RIPaBj4Jhvo?si=9xj4TnRkacOSs68L";

            try
            {
                // Configura la información de inicio del proceso
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                // Abre el enlace en el navegador predeterminado del sistema
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que ocurra al abrir el enlace
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string url = "https://youtu.be/QwLvrnlfdNo?si=G_zvOaRvhz4AWrth";

            try
            {
                // Configura la información de inicio del proceso
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                // Abre el enlace en el navegador predeterminado del sistema
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que ocurra al abrir el enlace
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
