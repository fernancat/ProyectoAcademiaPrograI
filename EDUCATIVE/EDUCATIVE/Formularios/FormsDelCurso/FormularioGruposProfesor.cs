using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;

namespace EDUCATIVE.Formularios.FormsDelCurso
{
    public partial class FormularioGruposProfesor : Form
    {
        public int cursoID;
        public Usuario usuario;

        private DataGridView guna2DataGridView1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private TextBox txtNombreGrupo;
        private Label lblNombreGrupo;
        private ListBox lstUsuarios;
        private Label lblUsuarios;

        public FormularioGruposProfesor(int cursoID, Usuario usuario)
        {
            this.cursoID = cursoID;
            this.usuario = usuario;
            InitializeComponent();
            InicializarFormulario();
            CargarDatosDataGridView();
        }

        private void InicializarFormulario()
        {
            this.Text = "Gestión de Grupos";
            this.Size = new Size(800, 600);

            guna2DataGridView1 = new DataGridView
            {
                Location = new Point(20, 20),
                Size = new Size(740, 200),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            guna2DataGridView1.CellClick += Guna2DataGridView1_CellClick;
            this.Controls.Add(guna2DataGridView1);

            lblNombreGrupo = new Label
            {
                Text = "Nombre del Grupo:",
                Location = new Point(20, 240)
            };
            this.Controls.Add(lblNombreGrupo);

            txtNombreGrupo = new TextBox
            {
                Location = new Point(150, 240),
                Width = 200
            };
            this.Controls.Add(txtNombreGrupo);

            btnAgregar = new Button
            {
                Text = "Agregar",
                Location = new Point(20, 280)
            };
            btnAgregar.Click += BtnAgregar_Click;
            this.Controls.Add(btnAgregar);

            btnActualizar = new Button
            {
                Text = "Actualizar",
                Location = new Point(120, 280)
            };
            btnActualizar.Click += BtnActualizar_Click;
            this.Controls.Add(btnActualizar);

            btnEliminar = new Button
            {
                Text = "Eliminar",
                Location = new Point(220, 280)
            };
            btnEliminar.Click += BtnEliminar_Click;
            this.Controls.Add(btnEliminar);

            lblUsuarios = new Label
            {
                Text = "Usuarios del Grupo:",
                Location = new Point(20, 320)
            };
            this.Controls.Add(lblUsuarios);

            lstUsuarios = new ListBox
            {
                Location = new Point(150, 320),
                Size = new Size(200, 100)
            };
            this.Controls.Add(lstUsuarios);
        }

        private void CargarDatosDataGridView()
        {
            guna2DataGridView1.Rows.Clear();

            if (guna2DataGridView1.Columns["IDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    Name = "IDColumn"
                };
                guna2DataGridView1.Columns.Add(columnaID);
            }

            if (guna2DataGridView1.Columns["NombreGrupoColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaNombreGrupo = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nombre del Grupo",
                    Name = "NombreGrupoColumn"
                };
                guna2DataGridView1.Columns.Add(columnaNombreGrupo);
            }

            if (guna2DataGridView1.Columns["CursoIDColumn"] == null)
            {
                DataGridViewTextBoxColumn columnaCursoID = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Curso ID",
                    Name = "CursoIDColumn"
                };
                guna2DataGridView1.Columns.Add(columnaCursoID);
            }

            GruposDAO gruposDAO = new GruposDAO();
            List<Grupo> grupos = gruposDAO.ObtenerGruposPorCurso(cursoID);

            if (grupos != null && grupos.Count > 0)
            {
                foreach (var grupo in grupos)
                {
                    guna2DataGridView1.Rows.Add(grupo.Id, grupo.Nombre, grupo.CursoId);
                }
            }
            else
            {
                MessageBox.Show("¡No hay grupos disponibles aún!.");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            GruposDAO gruposDAO = new GruposDAO();
            bool resultado = gruposDAO.CrearGrupo(txtNombreGrupo.Text, cursoID);

            if (resultado)
            {
                MessageBox.Show("Grupo agregado con éxito.");
                CargarDatosDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el grupo.");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null)
            {
                int idGrupo = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["IDColumn"].Value);
                GruposDAO gruposDAO = new GruposDAO();
                bool resultado = gruposDAO.ActualizarGrupo(idGrupo, txtNombreGrupo.Text, cursoID);

                if (resultado)
                {
                    MessageBox.Show("Grupo actualizado con éxito.");
                    CargarDatosDataGridView();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el grupo.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grupo para actualizar.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null)
            {
                int idGrupo = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["IDColumn"].Value);
                GruposDAO gruposDAO = new GruposDAO();
                bool resultado = gruposDAO.EliminarGrupo(idGrupo);

                if (resultado)
                {
                    MessageBox.Show("Grupo eliminado con éxito.");
                    CargarDatosDataGridView();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el grupo.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grupo para eliminar.");
            }
        }

        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && guna2DataGridView1.Rows[e.RowIndex].Cells["IDColumn"].Value != null)
            {
                DataGridViewRow fila = guna2DataGridView1.Rows[e.RowIndex];
                txtNombreGrupo.Text = fila.Cells["NombreGrupoColumn"].Value.ToString();
                int idGrupo = Convert.ToInt32(fila.Cells["IDColumn"].Value);
                CargarUsuariosGrupo(idGrupo);
            }
            else
            {
                MessageBox.Show("Seleccione una celda válida.");
            }
        }

        private void CargarUsuariosGrupo(int idGrupo)
        {
            lstUsuarios.Items.Clear();
            UsuariosGruposDAO usuariosGruposDAO = new UsuariosGruposDAO();
            List<Usuario> usuarios = usuariosGruposDAO.ObtenerUsuariosPorGrupo(idGrupo);

            if (usuarios != null && usuarios.Count > 0)
            {
                foreach (var usuario in usuarios)
                {
                    lstUsuarios.Items.Add(usuario.nombre_usuario);
                }
            }
            else
            {
                MessageBox.Show("¡No hay usuarios asignados a este grupo!.");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreGrupo.Clear();
            lstUsuarios.Items.Clear();
        }
    }
}
