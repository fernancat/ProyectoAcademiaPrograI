using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;

namespace EDUCATIVE.Formularios.FormsDelCurso
{
    public partial class FormularioEvaluacionEstudiante : Form
    {
        public Usuario usuario;
        public int IDCurso;
        private Button btnVerificarRespuestas;
        private List<Pruebas> pruebas;

        public FormularioEvaluacionEstudiante()
        {
            InitializeComponent();
            guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(guna2ComboBox1_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.FormLoad);

            // Configurar PanelPreguntas para que tenga scroll
            PanelPreguntas.AutoScroll = true;

            // Inicializar botón
            btnVerificarRespuestas = new Button
            {
                Text = "Verificar Respuestas",
                Size = new Size(200, 30)
            };
            btnVerificarRespuestas.Click += new EventHandler(this.BtnVerificarRespuestas_Click);
            this.Controls.Add(btnVerificarRespuestas);
        }

        public void FormLoad(object sender, EventArgs e)
        {
            cargarEvaluaciones();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = guna2ComboBox1.SelectedValue;
            if (selectedValue != null)
            {
                int evaluacionID = (int)selectedValue;
                cargarPruebas(evaluacionID);
            }
        }

        private void cargarEvaluaciones()
        {
            EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();

            List<Evaluaciones> evaluaciones = evaluacionesDAO.ObtenerEvaluaciones(IDCurso);
            if (evaluaciones != null && evaluaciones.Count > 0)
            {
                guna2ComboBox1.SelectedIndexChanged -= guna2ComboBox1_SelectedIndexChanged;

                guna2ComboBox1.DisplayMember = "titulo";
                guna2ComboBox1.ValueMember = "id";
                guna2ComboBox1.DataSource = evaluaciones;

                guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            }
            else
            {
                MessageBox.Show("¡No hay ningún foro aún! Crea uno");
            }
        }

        private void cargarPruebas(int evaluacionID)
        {
            PruebasDAO pruebasDAO = new PruebasDAO();
            pruebas = pruebasDAO.ObtenerPruebas(evaluacionID);

            if (pruebas != null && pruebas.Count > 0)
            {
                PanelPreguntas.Controls.Clear();

                int yOffset = 10;
                foreach (var prueba in pruebas)
                {
                    GroupBox groupBoxPregunta = new GroupBox
                    {
                        Text = prueba.pregunta,
                        Location = new Point(10, yOffset),
                        Size = new Size(500, 50) 
                    };

                    RadioButton rbtnVerdadero = new RadioButton
                    {
                        Text = "Verdadero",
                        Location = new Point(10, 20),
                        AutoSize = true,
                        Tag = prueba
                    };
                    groupBoxPregunta.Controls.Add(rbtnVerdadero);

                    RadioButton rbtnFalso = new RadioButton
                    {
                        Text = "Falso",
                        Location = new Point(100, 20),
                        AutoSize = true,
                        Tag = prueba
                    };
                    groupBoxPregunta.Controls.Add(rbtnFalso);

                    PanelPreguntas.Controls.Add(groupBoxPregunta);

                    yOffset += groupBoxPregunta.Height + 10;
                }

                btnVerificarRespuestas.Location = new Point(10, yOffset + 10);
                PanelPreguntas.Controls.Add(btnVerificarRespuestas);
            }
            else
            {
                MessageBox.Show("¡No hay pruebas para esta evaluación!");
            }
        }

        private void BtnVerificarRespuestas_Click(object sender, EventArgs e)
        {
            CalificacionesDAO calificacion = new CalificacionesDAO();
            int puntaje = 0;

            foreach (Control control in PanelPreguntas.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control rbtnControl in groupBox.Controls)
                    {
                        if (rbtnControl is RadioButton rbtn && rbtn.Checked)
                        {
                            Pruebas prueba = (Pruebas)rbtn.Tag;
                            if ((rbtn.Text == "Verdadero" && prueba.respuesta_correcta == "Verdadero") ||
                                (rbtn.Text == "Falso" && prueba.respuesta_correcta == "Falso"))
                            {
                                puntaje++;
                            }
                        }
                    }
                }
            }

            if (guna2ComboBox1.SelectedItem != null)
            {
                // Obtén el nombre de la evaluación del item seleccionado en el ComboBox
                string nombreEvaluacion = ((Evaluaciones)guna2ComboBox1.SelectedItem).titulo;

                // Muestra el mensaje con el nombre de la evaluación
                MessageBox.Show($"Tu puntuación en la evaluación {nombreEvaluacion} es: {puntaje} de {pruebas.Count}");

                if (puntaje > pruebas.Count / 2)
                {
                    calificacion.CrearCalificacion(usuario.Id, IDCurso, puntaje, nombreEvaluacion +" " + "Perfecto");
                }
                else
                {
                    calificacion.CrearCalificacion(usuario.Id, IDCurso, puntaje, nombreEvaluacion + " " +"Retroalimentacion");

                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna evaluación en el ComboBox.");
            }
        }
    }
}
