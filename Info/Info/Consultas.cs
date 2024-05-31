using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace Info
{
    public partial class Consultas : Form
    {

        SqlConnection connection = new SqlConnection("server=LAPTOP-1AVQ1L6A\\SQLEXPRESS; database=CONEC; integrated security=true; TrustServerCertificate=True");
        private string nombresText = "";
        public Consultas()
        {
            InitializeComponent();


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
                MessageBox.Show("Solicitud enviada te responderemos pronto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos :c : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void Nombres_TextChanged(object sender, EventArgs e)
        {
            nombresText = Nombres.Text;
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            EnviarDatos();
        }

        private void btonA_Click(object sender, EventArgs e)
        {
            
            DOOM formularioDOOM = new DOOM();

           
            formularioDOOM.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}