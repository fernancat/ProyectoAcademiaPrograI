using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCATIVE.Formularios.FormsDelCurso
{
    public partial class FormularioCargaContenidoEstudiantecs : Form
    {
        public Usuario usuario;
        public int idCurso;
        private TabControl tabControlContenidos;

        public FormularioCargaContenidoEstudiantecs()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            // Crear el TabControl
            tabControlContenidos = new TabControl();
            tabControlContenidos.Dock = DockStyle.Fill; 
            Controls.Add(tabControlContenidos); 
        }

        private void FormularioCargaContenidoEstudiantecs_Load(object sender, EventArgs e)
        {
            CargarContenidosCurso();
        }

        private void CargarContenidosCurso()
        {
            MaterialCursoDAO materialCursoDAO = new MaterialCursoDAO();

            List<MaterialCurso> contenidos = materialCursoDAO.ObtenerMaterialesCurso(idCurso);

            if (contenidos != null && contenidos.Count > 0)
            {
                foreach (var contenido in contenidos)
                {
                    RichTextBox richTextBoxContenido = new RichTextBox();
                    richTextBoxContenido.Dock = DockStyle.Fill;

                    TabPage tabPage = new TabPage(contenido.tipo +""); 
                    tabPage.Controls.Add(richTextBoxContenido);
                    tabControlContenidos.TabPages.Add(tabPage);

                    richTextBoxContenido.Text = contenido.contenido;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron contenidos para este curso.");
            }
        }
    }
}
