using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EDUCATIVE.Formularios.FormsDelCurso
{
    public partial class FormularioGrupoEstudiantecs : Form
    {
        public Usuario usuario;
        public int IDCurso;

        private DataGridView guna2DataGridView1;
        private Button btnAsignarse;
        private Label lblGrupos;
        private TableLayoutPanel tableLayoutPanel;

        public FormularioGrupoEstudiantecs(Usuario usuario, int IDCurso)
        {
            this.usuario = usuario;
            this.IDCurso = IDCurso;

            InitializeComponent();
            this.Load += new EventHandler(this.FormularioGrupoEstudiantecs_Load);
        }

        private void FormularioGrupoEstudiantecs_Load(object sender, EventArgs e)
        {
            InitializeComponents();
            CargarGrupos();
        }

        private void InitializeComponents()
        {
            this.guna2DataGridView1 = new DataGridView();
            this.btnAsignarse = new Button();
            this.lblGrupos = new Label();
            this.tableLayoutPanel = new TableLayoutPanel();

            this.tableLayoutPanel.Dock = DockStyle.Fill;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Para el label
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // Para el DataGridView
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Para el botón

            this.guna2DataGridView1.Dock = DockStyle.Fill;
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.MultiSelect = false;

            this.lblGrupos.Text = "Grupos disponibles";
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Margin = new Padding(10);

            this.btnAsignarse.Text = "Asignarse";
            this.btnAsignarse.AutoSize = true;
            this.btnAsignarse.Click += new EventHandler(this.BtnAsignarse_Click);

            this.tableLayoutPanel.Controls.Add(this.lblGrupos, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.guna2DataGridView1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnAsignarse, 0, 2);

            this.Controls.Add(this.tableLayoutPanel);

            this.Text = "Asignarse a un grupo";
            this.Size = new Size(450, 400);
        }

        private void CargarGrupos()
        {
            GruposDAO gruposDAO = new GruposDAO();
            List<Grupo> grupos = gruposDAO.ObtenerGruposPorCurso(IDCurso);

            if (grupos != null && grupos.Count > 0)
            {
                guna2DataGridView1.DataSource = grupos;
                guna2DataGridView1.Columns["ID"].Visible = false;
                guna2DataGridView1.Columns["CursoID"].Visible = false;
            }
            else
            {
                MessageBox.Show("No hay grupos disponibles para este curso.");
            }
        }

        private void BtnAsignarse_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int grupoID = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value);

                UsuariosGruposDAO usuariosGruposDAO = new UsuariosGruposDAO();
                bool asignado = usuariosGruposDAO.AsignarUsuarioAGrupo(usuario.Id, grupoID);

                if (asignado)
                {
                    MessageBox.Show("Te has asignado al grupo exitosamente.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al asignarte al grupo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un grupo.");
            }
        }
    }
}
