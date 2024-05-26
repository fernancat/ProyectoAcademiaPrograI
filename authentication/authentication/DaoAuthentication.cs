using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace login
{
  
       public class DaoAuthentication()
        {
            private string conexion = "Persist Security Info=False;User ID=sa;Initial Catalog=AUTENTICACION;Data Source=DESKTOP-07TI0C8; pwd=12345678";
            private SqlConnection sqlConnection;



            public Boolean LoguearUsuario(string usuario, string contraseña, Form formularioActual)
            {
                sqlConnection = new SqlConnection(conexion);
                try
                {
                    sqlConnection.Open();


                    string consulta = "SELECT * FROM usuarios WHERE nombre_usuario =@usuario AND contraseña = @contraseña";
                    SqlCommand comando = new SqlCommand(consulta, sqlConnection);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    SqlDataReader lector = comando.ExecuteReader();


                    if (lector.Read())
                    {
                        MessageBox.Show("Has iniciado sesion correctamente");

                        return true;
                       

                    }

                    return false;




                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No esta correcta la conexion");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Login");
                    MessageBox.Show("hubo un error a la hora de loguearse");
                    return false ;
                }
                finally
                {
                    if (sqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }



            }


        }
    }

