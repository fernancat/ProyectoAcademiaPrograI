using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCATIVE.Formularios
{
    public partial class Calificaciones : Form
    {
        private DBConexion context;
        public Calificaciones()
        {
            InitializeComponent();
        }

        public FormularioCalificaciones()
        {
            InitializeComponent();
            context = new DBConexion();
            CargarCalificaciones();
        }

        private void CargarCalificaciones()
        {
            var calificaciones = context.Calificaciones
                .Select(c => new
                {
                    c.Id,
                    Estudiante = c.Usuario.Nombre + " " + c.Usuario.Apellidos,
                    Curso = c.Curso.Titulo,
                    c.CalificacionValor,
                    Aprobado = c.CalificacionValor >= 61 ? "Aprobado" : "No Aprobado",
                    c.Comentarios
                })
                .ToList();
            dgb_Calificaciones.DataSource = calificaciones;
        }

        //no sirve

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //meto del boton para agregar la calificacion
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = txt_BuscarEstudiante.Text;
            string tituloCurso = comboBox_Cursos.Text;

            int usuarioId = CalificacionDAO.ObtenerIdUsuarioPorNombre(nombreEstudiante);
            int cursoId = CalificacionDAO.ObtenerCurso(tituloCurso);

            if (usuarioId == -1 || cursoId == -1)
            {
                MessageBox.Show("Estudiante o curso no encontrado.");
                return;
            }

            int calificacionValor;
            if (!int.TryParse(txt_Calificacion.Text, out calificacionValor))
            {
                MessageBox.Show("Por favor, ingresa una calificación válida.");
                return;
            }

            string comentarios = txt_Retroalimentacion.Text;

            var calificacion = new Calificacion
            {
                UsuarioId = usuarioId,
                CursoId = cursoId,
                CalificacionValor = calificacionValor,
                Comentarios = comentarios
            };

            if (CalificacionDAO.AgregarCalificacion(calificacion))
            {
                MessageBox.Show("Calificación asignada correctamente.");
                CargarCalificaciones();
            }
            else
            {
                MessageBox.Show("Error al asignar la calificación.");
            }
        }
        //Metodo del boton para actualizar calificaciones
        private void button2_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = txt_BuscarEstudiante.Text;
            string tituloCurso = comboBox_Cursos.Text;

            int usuarioId = CalificacionDAO.ObtenerIdUsuarioPorNombre(nombreEstudiante);
            int cursoId = CalificacionDAO.ObtenerIdCursoPorTitulo(tituloCurso);

            if (usuarioId == -1 || cursoId == -1)
            {
                MessageBox.Show("Estudiante o curso no encontrado.");
                return;
            }

            int calificacionValor;
            if (!int.TryParse(txt_Calificacion.Text, out calificacionValor))
            {
                MessageBox.Show("Por favor, ingresa una calificación válida.");
                return;
            }

            string comentarios = txt_Retroalimentacion.Text;

            var calificacion = new Calificacion
            {
                UsuarioId = usuarioId,
                CursoId = cursoId,
                CalificacionValor = calificacionValor,
                Comentarios = comentarios
            };

            if (CalificacionDAO.ActualizarCalificacion(calificacion))
            {
                MessageBox.Show("Calificación actualizada correctamente.");
                CargarCalificaciones();
            }
            else
            {
                MessageBox.Show("Error al actualizar la calificación.");
            }
        }

        private void btn_EliminarCalificacion_Click(object sender, EventArgs e)
        {
            if (dgb_Calificaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una calificación para actualizar.");
                return;
            }

            int calificacionId = (int)dgb_Calificaciones.SelectedRows[0].Cells["Id"].Value;

            var calificacion = context.Calificaciones.FirstOrDefault(c => c.Id == calificacionId);

            if (calificacion == null)
            {
                MessageBox.Show("Calificación no encontrada.");
                return;
            }

            int calificacionValor;
            if (!int.TryParse(txt_Calificacion.Text, out calificacionValor))
            {
                MessageBox.Show("Por favor, ingresa una calificación válida.");
                return;
            }

            string comentarios = txt_Retroalimentacion.Text;

            calificacion.CalificacionValor = calificacionValor;
            calificacion.Comentarios = comentarios;

            context.SaveChanges();

            MessageBox.Show("Calificación actualizada correctamente.");
            CargarCalificaciones();
        }

        private void bt_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarEstudiante.Clear();
            txt_BuscarId.Clear();
            comboBox_Cursos.SelectedIndex = -1;
            txt_Calificacion.Clear();
            txt_Retroalimentacion.Clear();

        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_MAX_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Minz_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
