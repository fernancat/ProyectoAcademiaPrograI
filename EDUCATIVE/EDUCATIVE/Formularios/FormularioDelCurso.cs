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
using EDUCATIVE.Models;
using EDUCATIVE.Formularios.FormsDelCurso;
using EDUCATIVE.DAOModels;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EDUCATIVE.DAOModels;
using Transparent_Form;
using Foro;
using EDUCATIVE.Formularios;

namespace EDUCATIVE
{
    public partial class FormularioDelCurso : Form
    {
        private int IdCurso;
        private Usuario usuario;
        private string tituloCurso;
        private ListView listViewCalificaciones;

        public FormularioDelCurso(Usuario usuario, int idCurso, string tituloCurso)
        {
            InitializeComponent();
            this.IdCurso = idCurso;
            this.usuario = usuario;
            this.tituloCurso = tituloCurso;
        }
        private void MostrarFormularioEnPanel(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenidoCursos.Controls.Clear();
            panelContenidoCursos.Controls.Add(formulario);
            formulario.Show();
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

        private void btn_Calificaciones_Click(object sender, EventArgs e)
        {
            FormularioCalificacionesProfesor form = new FormularioCalificacionesProfesor();

            form.usuario = usuario;
            form.IDCurso = IdCurso;

            MostrarFormularioEnPanel(form);


        }

        private void InicializarListView()
        {
            // Crear el control ListView
            listViewCalificaciones = new ListView
            {
                Size = new Size(800, 400),
                Location = new Point(10, 50),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };

            // Agregar columnas
            listViewCalificaciones.Columns.Add("Curso", 100);
            listViewCalificaciones.Columns.Add("Estudiante", 150);
            listViewCalificaciones.Columns.Add("Apellidos", 150);
            listViewCalificaciones.Columns.Add("Email", 200);
            listViewCalificaciones.Columns.Add("Calificación", 100);
            listViewCalificaciones.Columns.Add("Comentarios", 200);

            // Agregar el ListView al panelContenidoCursos
            panelContenidoCursos.Controls.Add(listViewCalificaciones);
        }


        private void FormularioDelCurso_Load(object sender, EventArgs e)
        {
            // Event handler para cuando se carga el formulario
        }

        // Métodos para manejar la interacción del usuario con la barra de título
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btn_Evaluaciones_Click(object sender, EventArgs e)
        {

            if (usuario.rol.Equals("Maestro"))
            {
                FormularioEvaluacionsYPruebas formProfesor = new FormularioEvaluacionsYPruebas();

                formProfesor.usuario = usuario;
                formProfesor.idCurso = IdCurso;

                MostrarFormularioEnPanel(formProfesor);
            }
            else if (usuario.rol.Equals("Estudiante"))
            {
                FormularioEvaluacionEstudiante formAlumno = new FormularioEvaluacionEstudiante();

                formAlumno.usuario = usuario;
                formAlumno.IDCurso = IdCurso;

                MostrarFormularioEnPanel(formAlumno);
            }
        }

        private void btn_Retroalimentacion_Click(object sender, EventArgs e) {

            if (usuario.rol.Equals("Maestro"))
            {
                FormularioGruposProfesor form = new FormularioGruposProfesor(IdCurso, usuario);
                MostrarFormularioEnPanel(form);

            }
            else if (usuario.rol.Equals("Estudiante"))
            {
                FormularioGrupoEstudiantecs form = new FormularioGrupoEstudiantecs(usuario, IdCurso);
                MostrarFormularioEnPanel(form);
            
            }
              


        
        }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void btn_Foros_Click(object sender, EventArgs e)
        {

            if (usuario.rol.Equals("Maestro"))
            {
                ForosForm formularioForos = new ForosForm();
                formularioForos.usuario = usuario;
                formularioForos.IDCurso = IdCurso;

                MostrarFormularioEnPanel(formularioForos);

            }
            else if (usuario.rol.Equals("Estudiante"))
            {

                ForosForm formularioForos = new ForosForm();
                formularioForos.usuario = usuario;
                formularioForos.IDCurso = IdCurso;
                MostrarFormularioEnPanel(formularioForos);


            }


        }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void Btn_MaterialesCurso_Click(object sender, EventArgs e)
        {
            if (usuario.rol.Equals("Maestro"))
            {
                {
                    FormularioMaterialProfesor formProfesor = new FormularioMaterialProfesor();
                    formProfesor.usuario = usuario;
                    formProfesor.idCurso = IdCurso;
                    MostrarFormularioEnPanel(formProfesor);
                }
            }
            else if (usuario.rol.Equals("Estudiante"))
            {
                FormularioCargaContenidoEstudiantecs formAlumno = new FormularioCargaContenidoEstudiantecs();
                formAlumno.usuario = usuario;
                formAlumno.idCurso = IdCurso;
                MostrarFormularioEnPanel(formAlumno);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            informacionProgreso.InformacionYProgreso reportes = new informacionProgreso.InformacionYProgreso();

            reportes.usuario = usuario;
            reportes.IDCurso = IdCurso;
            MostrarFormularioEnPanel(reportes);
        }
    }
}
