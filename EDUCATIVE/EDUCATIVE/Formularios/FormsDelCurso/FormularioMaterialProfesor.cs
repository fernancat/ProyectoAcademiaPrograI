using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Transparent_Form
{
    public partial class FormularioMaterialProfesor : Form
    {
        public Usuario usuario;
        public int idCurso;
        public int idMaterial;
        public FormularioMaterialProfesor()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();

        }

       
        private void CargarDatosDataGridView()
        {
            DataGridView_course.Rows.Clear();

            if (DataGridView_course.Columns["IDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
                columnaID.HeaderText = "ID";
                columnaID.Name = "IDColumn"; 
                DataGridView_course.Columns.Add(columnaID);
            }

            if (DataGridView_course.Columns["CursoIDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaCursoID = new DataGridViewTextBoxColumn();
                columnaCursoID.HeaderText = "Curso ID";
                columnaCursoID.Name = "CursoIDColumn"; 
                DataGridView_course.Columns.Add(columnaCursoID);
            }

            if (DataGridView_course.Columns["TipoColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
                columnaTipo.HeaderText = "Tipo";
                columnaTipo.Name = "TipoColumn"; 
                DataGridView_course.Columns.Add(columnaTipo);
            }

            if (DataGridView_course.Columns["ContenidoColumn"] == null)
            {
                DataGridViewTextBoxColumn contenido = new DataGridViewTextBoxColumn();
                contenido.HeaderText = "Contenido/URL";
                contenido.Name = "ContenidoColumn"; 
                DataGridView_course.Columns.Add(contenido);
            }

            MaterialCursoDAO materialCurso = new MaterialCursoDAO();
            List<MaterialCurso> materiales = materialCurso.ObtenerMaterialesCurso(idCurso);

            if (materiales != null && materiales.Count > 0)
            {
                foreach (MaterialCurso material in materiales)
                {
                    DataGridView_course.Rows.Add(material.Id, material.idCurso, material.tipo, material.contenido);
                }
            }
            else
            {
                MessageBox.Show("¡No hay materiales disponibles aún! Crea uno.");
            }
        }




        private void DataGridView_course_Click(object sender, EventArgs e)
        {
            // Obtener el valor de la celda seleccionada en la columna "Tipo"
            object tipoValue = DataGridView_course.CurrentRow.Cells["TipoColumn"].Value;
            object elcontenido = DataGridView_course.CurrentRow.Cells["ContenidoColumn"].Value;
            object id = DataGridView_course.CurrentRow.Cells["IDColumn"].Value;
            if (tipoValue != null & elcontenido != null)
            {
                string tipoSeleccionado = tipoValue.ToString();
                string contenidoSeleccionado = elcontenido.ToString();

                // Buscar el índice del valor seleccionado en el ComboBox
                int indice = comboxTipo.FindStringExact(tipoSeleccionado);

                if (indice != -1)
                {
                    // Establecer el índice seleccionado del ComboBox
                    comboxTipo.SelectedIndex = indice;
                    Contenido.Text = contenidoSeleccionado;
                    idMaterial = int.Parse(id.ToString());

                }
                else
                {
                    MessageBox.Show("La opción seleccionada no está disponible en el ComboBox.");
                }
            }
            else
            {
                MessageBox.Show("La celda seleccionada no tiene un valor.");
            }
        }


        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton_crearMaterial_Click(object sender, EventArgs e)
        {
            string Tipo = comboxTipo.Text;
            string contenido = Contenido.Text;

            if (!String.IsNullOrEmpty(Tipo) && !string.IsNullOrEmpty(contenido))
            {

                MaterialCursoDAO materialCurso = new MaterialCursoDAO();

                materialCurso.AgregarMaterialCurso(idCurso, Tipo, contenido);


                CargarDatosDataGridView();

            }
            else
            {
                MessageBox.Show("No puedes crear contenido vacio");
            }
        }

        private void btn_Actualizar_Material_Click(object sender, EventArgs e)
        {
            string Tipo = comboxTipo.Text;
            string contenido = Contenido.Text;

            if (!String.IsNullOrEmpty(Tipo) && !string.IsNullOrEmpty(contenido))
            {

                MaterialCursoDAO materialCurso = new MaterialCursoDAO();

                materialCurso.EditarMaterialCurso(idMaterial, Tipo, contenido);


                CargarDatosDataGridView();

            }
            else
            {
                MessageBox.Show("No puedes crear contenido vacio");
            }
        }

        private void boton_Borrar_Material_Click(object sender, EventArgs e)
        {
            MaterialCursoDAO materialCursoDAO = new MaterialCursoDAO();
            bool borradoExitoso = materialCursoDAO.BorrarMaterialCurso(idMaterial);

            if (borradoExitoso)
            {
                MessageBox.Show("Material borrado exitosamente.");
                CargarDatosDataGridView();
            }
            else
            {
                MessageBox.Show("No se pudo borrar el material. Asegúrate de que el ID del material sea válido.");
            }
        }
    }
}
