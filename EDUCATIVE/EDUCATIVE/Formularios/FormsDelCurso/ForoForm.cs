using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;

namespace Foro
{
    public partial class ForosForm : Form
    {
        public Usuario usuario;
        public int IDCurso;

        public ForosForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormLoad);
            comboBox_Foros.SelectedIndexChanged += new System.EventHandler(this.comboBox_Foros_SelectedIndexChanged);
            ComboBoxPreguntas.SelectedIndexChanged += new System.EventHandler(this.comboBox_Preguntas_SelectedIndexChanged);
        }

        private void FormLoad(object sender, EventArgs e)
        {
            if (usuario.rol == "Estudiante")
            {
                panelPreguntaMaestro.Visible = false;
                panelMaestroForo.Visible = false;
            }

            LoadForos();
        }

        private void LoadForos()
        {
            ForoDAOcs foroDAO = new ForoDAOcs();
            List<ForosModel> foros = foroDAO.ObtenerForos(IDCurso);

            if (foros != null && foros.Count > 0)
            {
                comboBox_Foros.DisplayMember = "titulo";
                comboBox_Foros.ValueMember = "id";
                comboBox_Foros.DataSource = foros;
            }
            else
            {
                MessageBox.Show("¡No hay ningún foro aún! Crea uno");
            }
        }

        private void LoadPreguntas(int foroId)
        {
            PreguntaForoDAO preguntaForoDAO = new PreguntaForoDAO();
            List<PreguntaForo> preguntas = preguntaForoDAO.ObtenerPreguntasForo(foroId);

            if (preguntas != null && preguntas.Count > 0)
            {
                ComboBoxPreguntas.DisplayMember = "pregunta";
                ComboBoxPreguntas.ValueMember = "id";
                ComboBoxPreguntas.DataSource = preguntas;
            }
            else
            {
                ComboBoxPreguntas.DataSource = null;
            }
        }

        private void LoadRespuestas(int preguntaId)
        {
            MensajeForoDAO mensajeForoDAO = new MensajeForoDAO();
            List<MensajeForo> mensajes = mensajeForoDAO.ObtenerMensajesForo(preguntaId);

            if (mensajes != null && mensajes.Count > 0)
            {
                listBox1.DisplayMember = "mensaje";
                listBox1.ValueMember = "id";
                listBox1.DataSource = mensajes;
            }
            else
            {
                listBox1.DataSource = null;
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Miniz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // no sirve 
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {
            // no sirve 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // no sirve 
        }

        private void btn_AgraegarForo_Click(object sender, EventArgs e)
        {
            string tituloForo = txt_Titulo.Text;
            string descripcionForo = txt_Descripcion.Text;

            if (!string.IsNullOrEmpty(tituloForo) && !string.IsNullOrEmpty(descripcionForo))
            {
                ForoDAOcs foroDao = new ForoDAOcs();

                if (foroDao.CrearForo(IDCurso, tituloForo, descripcionForo))
                {
                    LoadForos();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el foro correctamente");
                }
            }
            else
            {
                MessageBox.Show("No pueden haber caracteres especiales o espacios en blanco");
            }
        }

        private void btn_EnviarRespuestas_Click(object sender, EventArgs e)
        {
            if (ComboBoxPreguntas.SelectedValue != null)
            {
                int preguntaId = (int)ComboBoxPreguntas.SelectedValue;
                string mensaje = txt_Respuestas.Text;

                if (!string.IsNullOrEmpty(mensaje))
                {
                    MensajeForoDAO mensajeDao = new MensajeForoDAO();
                    if (mensajeDao.CrearMensajeForo(preguntaId, mensaje))
                    {
                        LoadRespuestas(preguntaId); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la respuesta");
                    }
                }
                else
                {
                    MessageBox.Show("La respuesta no puede estar vacía");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una pregunta para agregar la respuesta");
            }
        }

        private void listBox_Foros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementación de seleccionar foro en el ListBox
        }

        private void listBox_Respuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementación de seleccionar respuesta en el ListBox
        }

        private void comboBox_Foros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Foros.SelectedValue != null)
            {
                int foroId = (int)comboBox_Foros.SelectedValue;
                LoadPreguntas(foroId);
            }
        }

        private void comboBox_Preguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPreguntas.SelectedValue != null)
            {
                int preguntaId = (int)ComboBoxPreguntas.SelectedValue;
                LoadRespuestas(preguntaId);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // no sirve 
        }

        private void ComboBoxPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // no sirve
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Foros.SelectedValue != null)
            {
                int foroId = (int)comboBox_Foros.SelectedValue;
                string pregunta = txtPregunta.Text;

                if (!string.IsNullOrEmpty(pregunta))
                {
                    PreguntaForoDAO preguntaDao = new PreguntaForoDAO();
                    if (preguntaDao.CrearPreguntaForo(foroId, pregunta))
                    {
                        MessageBox.Show("Pregunta agregada correctamente");
                        LoadPreguntas(foroId); // Recargar las preguntas después de agregar una nueva
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la pregunta");
                    }
                }
                else
                {
                    MessageBox.Show("La pregunta no puede estar vacía");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un foro para agregar la pregunta");
            }
        }
    }
}
