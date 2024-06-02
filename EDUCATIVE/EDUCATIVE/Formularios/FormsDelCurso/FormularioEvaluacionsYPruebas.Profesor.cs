using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCATIVE.Formularios.FormsDelCurso
{
    public partial class FormularioEvaluacionsYPruebas : Form
    {
        public Usuario usuario;
        public int idCurso;

        public FormularioEvaluacionsYPruebas()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormularioLoad);
            datGridViewEvaluaciones.SelectionChanged += new System.EventHandler(this.datGridViewEvaluaciones_SelectionChanged);
            dataGridViewPreguntas.SelectionChanged += new System.EventHandler(this.dataGridViewPreguntas_SelectionChanged);
        }

        private void datGridViewEvaluaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (datGridViewEvaluaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = datGridViewEvaluaciones.SelectedRows[0];

                // Verificar que las celdas no sean nulas
                if (filaSeleccionada.Cells["TituloColumn"].Value != null && filaSeleccionada.Cells["DescripcionColumn"].Value != null)
                {
                    tituloEvaluacion.Text = filaSeleccionada.Cells["TituloColumn"].Value.ToString();
                    descripcionEvaluacion.Text = filaSeleccionada.Cells["DescripcionColumn"].Value.ToString();

                    CargarDatosDataGridViewPreguntas();
                }
            }
        }

        private void dataGridViewPreguntas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPreguntas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPreguntas.SelectedRows[0];

                // Verificar que las celdas no sean nulas
                if (filaSeleccionada.Cells["PreguntaColumn"].Value != null && filaSeleccionada.Cells["RespuestaColumn"].Value != null)
                {
                    txtPregunta.Text = filaSeleccionada.Cells["PreguntaColumn"].Value.ToString();
                    txtRespuesta.Text = filaSeleccionada.Cells["RespuestaColumn"].Value.ToString();
                }
            }
        }

        private void FormularioLoad(object sender, EventArgs e)
        {
            CargarDatosDataGridViewEvaluaciones();
        }

        private void CargarDatosDataGridViewEvaluaciones()
        {
            datGridViewEvaluaciones.Rows.Clear();

            if (datGridViewEvaluaciones.Columns["IDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "IDColumn"
                };
                datGridViewEvaluaciones.Columns.Add(columnaID);
            }

            if (datGridViewEvaluaciones.Columns["CursoIDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaCursoID = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Curso ID",
                    Name = "CursoIDColumn"
                };
                datGridViewEvaluaciones.Columns.Add(columnaCursoID);
            }

            if (datGridViewEvaluaciones.Columns["TituloColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaTitulo = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Titulo",
                    Name = "TituloColumn"
                };
                datGridViewEvaluaciones.Columns.Add(columnaTitulo);
            }

            if (datGridViewEvaluaciones.Columns["DescripcionColumn"] == null)
            {
                DataGridViewTextBoxColumn descripcion = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Descripcion",
                    Name = "DescripcionColumn"
                };
                datGridViewEvaluaciones.Columns.Add(descripcion);
            }

            EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
            List<Evaluaciones> evaluaciones = evaluacionesDAO.ObtenerEvaluaciones(idCurso);

            if (evaluaciones != null && evaluaciones.Count > 0)
            {
                foreach (Evaluaciones evaluacion in evaluaciones)
                {
                    datGridViewEvaluaciones.Rows.Add(evaluacion.id, evaluacion.curso_id, evaluacion.titulo, evaluacion.descripcion);
                }
            }
            else
            {
                MessageBox.Show("¡No hay Evaluaciones disponibles aún! Crea una.");
            }
        }

        private void CargarDatosDataGridViewPreguntas()
        {
            dataGridViewPreguntas.Rows.Clear();

            if (dataGridViewPreguntas.Columns["IDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "IDColumn"
                };
                dataGridViewPreguntas.Columns.Add(columnaID);
            }

            if (dataGridViewPreguntas.Columns["EvaluacionIDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaEvaluacionID = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Evaluacion ID",
                    Name = "EvaluacionIDColumn"
                };
                dataGridViewPreguntas.Columns.Add(columnaEvaluacionID);
            }

            if (dataGridViewPreguntas.Columns["PreguntaColumn"] == null)
            {
                DataGridViewTextBoxColumn preguntaColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Pregunta",
                    Name = "PreguntaColumn"
                };
                dataGridViewPreguntas.Columns.Add(preguntaColumn);
            }

            if (dataGridViewPreguntas.Columns["RespuestaColumn"] == null)
            {
                DataGridViewTextBoxColumn respuesta = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Respuesta Correcta",
                    Name = "RespuestaColumn"
                };
                dataGridViewPreguntas.Columns.Add(respuesta);
            }

            PruebasDAO pruebasDAO = new PruebasDAO();
            List<Pruebas> pruebas = pruebasDAO.ObtenerPruebas(obtenerIDEvaluacion());

            if (pruebas != null && pruebas.Count > 0)
            {
                foreach (Pruebas prueba in pruebas)
                {
                    dataGridViewPreguntas.Rows.Add(prueba.id, prueba.evaluacion_id, prueba.pregunta, prueba.respuesta_correcta);
                }
            }
            else
            {
                MessageBox.Show("¡No hay Preguntas disponibles aún! Crea una.");
            }
        }

        private int obtenerIDEvaluacion()
        {
            if (datGridViewEvaluaciones.CurrentRow != null)
            {
                return int.Parse(datGridViewEvaluaciones.CurrentRow.Cells["IDColumn"].Value.ToString());
            }
            else
            {
                return -1; // Retorna un valor inválido o maneja el caso donde no haya una fila seleccionada
            }
        }

        private int obtnerIDPregunta()
        {
            if (dataGridViewPreguntas.CurrentRow != null)
            {
                return int.Parse(dataGridViewPreguntas.CurrentRow.Cells["IDColumn"].Value.ToString());
            }
            else
            {
                return -1; // Retorna un valor inválido o maneja el caso donde no haya una fila seleccionada
            }
        }

        private void btnAgregarEvaluacion_Click(object sender, EventArgs e)
        {
            string titulo = tituloEvaluacion.Text;
            string descripcion = descripcionEvaluacion.Text;

            if (!string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(descripcion))
            {
                EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
                evaluacionesDAO.CrearEvaluacion(idCurso, titulo, descripcion);
                CargarDatosDataGridViewEvaluaciones();
            }
            else
            {
                MessageBox.Show("Datos invalidos no debes dejar espacios o caracteres especiales");
            }
        }

        private void btnAgregarPregunta_Click(object sender, EventArgs e)
        {
            string pregunta = txtPregunta.Text;
            string respuestaCorrecta = txtRespuesta.Text;

            if (!string.IsNullOrEmpty(pregunta) && !string.IsNullOrEmpty(respuestaCorrecta))
            {
                if (respuestaCorrecta.Equals("Verdadero") || respuestaCorrecta.Equals("Falso"))
                {
                    PruebasDAO prueba = new PruebasDAO();
                    prueba.CrearPrueba(obtenerIDEvaluacion(), pregunta, respuestaCorrecta);
                    CargarDatosDataGridViewPreguntas();
                }
                else
                {
                    MessageBox.Show("Solo puedes escribir en la Respuesta Verdadero o Falso");
                }
            }
            else
            {
                MessageBox.Show("Datos invalidos no debes dejar espacios o caracteres especiales");
            }
        }

        private void btnActualizarEvaluacion_Click(object sender, EventArgs e)
        {
            string titulo = tituloEvaluacion.Text;
            string descripcion = descripcionEvaluacion.Text;
            int evaluacion = obtenerIDEvaluacion();

            if (!string.IsNullOrEmpty(titulo) && !string.IsNullOrEmpty(descripcion))
            {
                EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
                evaluacionesDAO.ActualizarEvaluacion(evaluacion, titulo, descripcion);
                CargarDatosDataGridViewEvaluaciones();
            }
            else
            {
                MessageBox.Show("Los campos especificados no pueden estar vacios");
            }
        }

        private void btnEliminarEvaluacion_Click(object sender, EventArgs e)
        {
            int evaluacion = obtenerIDEvaluacion();

            EvaluacionesDAO evaluacionesDAO = new EvaluacionesDAO();
            evaluacionesDAO.borrarEvaluacion(evaluacion);
            CargarDatosDataGridViewEvaluaciones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string pregunta = txtPregunta.Text;
            string respuestaCorrecta = txtRespuesta.Text;

            if (!string.IsNullOrEmpty(pregunta) && !string.IsNullOrEmpty(respuestaCorrecta))
            {
                if (respuestaCorrecta.Equals("Verdadero") || respuestaCorrecta.Equals("Falso"))
                {
                    PruebasDAO prueba = new PruebasDAO();
                    prueba.ActualizarPrueba(obtnerIDPregunta(), pregunta, respuestaCorrecta);
                    CargarDatosDataGridViewPreguntas();
                }
                else
                {
                    MessageBox.Show("Solo puedes escribir en la Respuesta Verdadero o Falso");
                }
            }
            else
            {
                MessageBox.Show("Datos invalidos no debes dejar espacios o caracteres especiales");
            }
        }

        private void btnEliminarPregunta_Click(object sender, EventArgs e)
        {
            PruebasDAO prueba = new PruebasDAO();
            prueba.BorrarPrueba(obtnerIDPregunta());
            CargarDatosDataGridViewPreguntas();
        }
    }
}

