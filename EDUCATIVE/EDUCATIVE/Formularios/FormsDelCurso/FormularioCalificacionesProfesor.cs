using System;
using System.Windows.Forms;
using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;

namespace EDUCATIVE.Formularios.FormsDelCurso
{
    public partial class FormularioCalificacionesProfesor : Form
    {
        public Usuario usuario;
        public int IDCurso;

        public FormularioCalificacionesProfesor()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormLoad);
            guna2DataGridView1.CellClick += new DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                TextBoxDescripcion.Text = row.Cells["ComentarioColumn"].Value.ToString();
                TextBoxCalificacion.Text = row.Cells["CalificacionCloum"].Value.ToString();
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            guna2DataGridView1.Rows.Clear();

            if (guna2DataGridView1.Columns["IDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
                columnaID.HeaderText = "ID";
                columnaID.Name = "IDColumn";
                guna2DataGridView1.Columns.Add(columnaID);
            }

            if (guna2DataGridView1.Columns["UsuarioIDColumn"] == null)
            {
                DataGridViewTextBoxColumn UsuarioID = new DataGridViewTextBoxColumn();
                UsuarioID.HeaderText = "UsuarioID";
                UsuarioID.Name = "UsuarioIDColumn";
                guna2DataGridView1.Columns.Add(UsuarioID);
            }

            if (guna2DataGridView1.Columns["CursoIDColumn"] == null)
            {
                DataGridViewTextBoxColumn CursoID = new DataGridViewTextBoxColumn();
                CursoID.HeaderText = "Curso ID";
                CursoID.Name = "CursoIDColumn";
                guna2DataGridView1.Columns.Add(CursoID);
            }

            if (guna2DataGridView1.Columns["CalificacionCloum"] == null)
            {
                DataGridViewTextBoxColumn Calificacion = new DataGridViewTextBoxColumn();
                Calificacion.HeaderText = "Calificacion";
                Calificacion.Name = "CalificacionCloum";
                guna2DataGridView1.Columns.Add(Calificacion);
            }

            if (guna2DataGridView1.Columns["ComentarioColumn"] == null)
            {
                DataGridViewTextBoxColumn comentario = new DataGridViewTextBoxColumn();
                comentario.HeaderText = "Comentario";
                comentario.Name = "ComentarioColumn";
                guna2DataGridView1.Columns.Add(comentario);
            }

            if (usuario.rol.Equals("Maestro"))
            {
                CalificacionesDAO calificacionesDAO = new CalificacionesDAO();
                List<Calificacion> calificaciones = calificacionesDAO.ObtenerCalificacionesPorCurso(IDCurso);

                if (calificaciones != null && calificaciones.Count > 0)
                {
                    foreach (var calificacion in calificaciones)
                    {
                        guna2DataGridView1.Rows.Add(calificacion.Id, calificacion.IdCurso, calificacion.IdUsuario, calificacion.CalificacionValor, calificacion.Comentarios);
                    }
                }
                else
                {
                    MessageBox.Show("¡No hay Calificaciones disponibles aún!.");
                }
            }else if (usuario.rol.Equals("Estudiante"))
            {
                TextBoxCalificacion.Visible = false;
                TextBoxDescripcion.Visible = false;
                guna2HtmlLabel1.Visible = false;
                guna2HtmlLabel2.Visible = false;
                ActualizarCalificacion.Visible = false;
                CalificacionesDAO calificacionesDAO = new CalificacionesDAO();
                List<Calificacion> calificaciones = calificacionesDAO.ObtenerCalificaciones(usuario.Id);

                if (calificaciones != null && calificaciones.Count > 0)
                {
                    foreach (var calificacion in calificaciones)
                    {
                        guna2DataGridView1.Rows.Add(calificacion.Id, calificacion.IdCurso, calificacion.IdUsuario, calificacion.CalificacionValor, calificacion.Comentarios);
                    }
                }
                else
                {
                    MessageBox.Show("¡No hay Calificaciones disponibles aún!.");
                }
            }

           
        }

        private void ActualizarCalificacion_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int idCalificacion = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["IDColumn"].Value);
                int calificacion = Convert.ToInt32(TextBoxCalificacion.Text);
                string comentario = TextBoxDescripcion.Text;

                CalificacionesDAO calificacionesDAO = new CalificacionesDAO();
                Calificacion calificacion1 = new Calificacion();
                calificacion1.Id = idCalificacion;
                calificacion1.CalificacionValor = calificacion;
                calificacion1.Comentarios = comentario;

                if (calificacionesDAO.ActualizarCalificacion(calificacion1))
                {
                    MessageBox.Show("Calificación actualizada correctamente.");
                    CargarDatosDataGridView(); 
                }
                else
                {
                    MessageBox.Show("Error al actualizar la calificación.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una calificación para actualizar.");
            }
        }
    }
}
