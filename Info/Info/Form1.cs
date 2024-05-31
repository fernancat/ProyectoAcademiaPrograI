using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace Info
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("server=LAPTOP-1AVQ1L6A\\SQLEXPRESS; database=CONEC; integrated security=true; TrustServerCertificate=True");
        private string nombresText = "";
        public Form1()
        {
            InitializeComponent();

            // Asociar el evento TextChanged del TextBox "Nombres" con el método Nombres_TextChanged
            Nombres.TextChanged += Nombres_TextChanged;
        }

        private void EnviarDatos()
        {
            try
            {
                connection.Open();
                string consulta = "INSERT INTO nombres (name1) VALUES (@nombres)";
                SqlCommand comando = new SqlCommand(consulta, connection);
                comando.Parameters.AddWithValue("@nombres", nombresText);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Manejador de evento para el cambio de texto en el TextBox "Nombres"
        private void Nombres_TextChanged(object sender, EventArgs e)
        {
            nombresText = Nombres.Text; // Actualizar la variable con el texto del TextBox
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            EnviarDatos();
        }
    }
}