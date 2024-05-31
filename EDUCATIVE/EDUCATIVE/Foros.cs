using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foro
{
    public partial class ForosForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter cursosAdapter;
        private SqlDataAdapter forosAdapter;
        private SqlDataAdapter respuestasAdapter;
        private DataSet dataSet;
        private int currentUserId;
        private string currentUserRole;

        public ForosForm(int userId, string userRole)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUserRole = userRole;
            InitializeDatabase();
            LoadCursos();
        }

        private void InitializeDatabase()
        {
            //Remplaza la cadena de conexion con la base de datos
            string connectionString = "conexion a BD-Agregarla porfa :v";
            connection = new SqlConnection(connectionString);
            dataSet = new DataSet();
        }

        private void LoadCursos()
        {
            string query = "SELECT id, titulo FROM cursos";
            cursosAdapter = new SqlDataAdapter(query, connection);
            cursosAdapter.Fill(dataSet, "Cursos");

            comboBox_Cursos.DataSource = dataSet.Tables["Cursos"];
            comboBox_Cursos.DisplayMember = "titulo";
            comboBox_Cursos.ValueMember = "id";
        }

        private void LoadForos(int cursoId)
        {
            string query = "SELECT f.id, f.titulo, u.nombre + ' ' + u.apellidos AS creador FROM foros f JOIN usuarios u ON f.usuario_id = u.id WHERE f.curso_id = @cursoId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@cursoId", cursoId);
            forosAdapter = new SqlDataAdapter(command);

            if (dataSet.Tables["Foros"] != null)
            {
                dataSet.Tables["Foros"].Clear();
            }

            forosAdapter.Fill(dataSet, "Foros");

            listBox_Foros.DataSource = dataSet.Tables["Foros"];
            listBox_Foros.DisplayMember = "titulo";
            listBox_Foros.ValueMember = "id";
        }

        private void LoadRespuestas(int foroId)
        {
            string query = "SELECT mf.mensaje, u.nombre + ' ' + u.apellidos AS autor, mf.fecha FROM mensajes_foro mf JOIN usuarios u ON mf.usuario_id = u.id WHERE mf.foro_id = @foroId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@foroId", foroId);
            respuestasAdapter = new SqlDataAdapter(command);

            if (dataSet.Tables["Respuestas"] != null)
            {
                dataSet.Tables["Respuestas"].Clear();
            }

            respuestasAdapter.Fill(dataSet, "Respuestas");

            listBox_Respuestas.DataSource = dataSet.Tables["Respuestas"];
            listBox_Respuestas.DisplayMember = "mensaje";
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
        //no sirve
        private void label2_Click(object sender, EventArgs e)
        {
            //no sirve 
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {
            //no sirve 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //no sirve 
        }

        //Botoes para agregar, eliminar y buscar foros y tambien el boton para envuiar respuesta
        private void btn_AgraegarForo_Click(object sender, EventArgs e)
        {
            {
                if (currentUserRole != "Maestro") //O docente verifica s
                {
                    MessageBox.Show("Solo los maestros pueden crear foros.");
                    return;
                }

                int cursoId = (int)comboBox_Cursos.SelectedValue;
                string titulo = txt_Descripcion.Text;
                string descripcion = txt_Descripcion.Text;

                string query = "INSERT INTO foros (curso_id, titulo, descripcion, usuario_id) VALUES (@cursoId, @titulo, @descripcion, @usuarioId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cursoId", cursoId);
                command.Parameters.AddWithValue("@titulo", titulo);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@usuarioId", currentUserId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadForos(cursoId);
            }

        }

        private void btn_EnviarRespuestas_Click(object sender, EventArgs e)
        {
            {
                if (listBox_Foros.SelectedValue != null)
                {
                    int foroId = (int)listBox_Foros.SelectedValue;
                    string mensaje = txt_Respuestas.Text;

                    string query = "INSERT INTO mensajes_foro (foro_id, usuario_id, mensaje) VALUES (@foroId, @usuarioId, @mensaje)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@foroId", foroId);
                    command.Parameters.AddWithValue("@usuarioId", currentUserId);
                    command.Parameters.AddWithValue("@mensaje", mensaje);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadRespuestas(foroId);
                }
            }
        }

        //Eventos para los list box para ver qe foros hay disponibles y las respuestas de los estudiantes
        private void listBox_Foros_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listBox_Foros.SelectedValue != null)
                {
                    int foroId = (int)listBox_Foros.SelectedValue;
                    LoadRespuestas(foroId);
                }
            }

        }

        private void listBox_Respuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (comboBox_Cursos.SelectedValue != null)
                {
                    int cursoId = (int)comboBox_Cursos.SelectedValue;
                    LoadForos(cursoId);
                }
            }
        }
    }
}
