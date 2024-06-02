using System;
using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using SesionInicio;

namespace INNICIO
{
    public partial class FormularioPantallaDeCarga : Form
    {
        private System.Windows.Forms.Timer progressBarTimer;
        private SoundPlayer soundPlayer;

        public FormularioPantallaDeCarga()
        {
            InitializeComponent();
            InitializeProgressBarTimer();
            CustomizeProgressBarColor();

            soundPlayer = new SoundPlayer(@"C:\Users\Fernan\Documents\ProyectoAcademiaPrograI\EDUCATIVE\EDUCATIVE\IMGS\music.wav");
            soundPlayer.Play();
        }

        private void CustomizeProgressBarColor()
        {
            
            progressBar1.ForeColor = Color.Blue;

            
            progressBar1.Style = ProgressBarStyle.Continuous; 
        }

        private void InitializeProgressBarTimer()
        {
            progressBarTimer = new System.Windows.Forms.Timer();
            progressBarTimer.Interval = 70; 
            progressBarTimer.Tick += ProgressBarTimer_Tick;
            progressBarTimer.Start();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                progressBarTimer.Stop();
                soundPlayer.Stop();
                this.Hide();
                Login formularioLogin = new Login();
                formularioLogin.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://umg.edu.gt/miumg/";

            try
            {
                
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/u.marianogalvez/";

            try
            {
                
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://youtu.be/RIPaBj4Jhvo?si=9xj4TnRkacOSs68L";

            try
            {
               
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

               
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string url = "https://youtu.be/QwLvrnlfdNo?si=G_zvOaRvhz4AWrth";

            try
            {
                
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al abrir el enlace: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
        
    }
}
