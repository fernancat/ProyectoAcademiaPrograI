using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUCATIVE.Models;
using System.Data.SqlClient;

namespace EDUCATIVE.DAOModels

{
   class auhentication()
    {
        private string conexion = "Persist Security Info=False;User ID=sa;Initial Catalog=Academia;Data Source=DESKTOP-07TI0C8; pwd=12345678";
        private SqlConnection sqlConnection;
        
        

        public Usuario LoguearUsuario(string usuario, string contraseña, Form formularioActual)
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
                    Usuario usuario1 = new Usuario
                    {
                        Id = Convert.ToInt32(lector["id_usuario"]),
                        nombre_usuario = lector["nombre_usuario"].ToString(),
                        email = lector["email"].ToString(),
                        contraseña = lector["contraseña"].ToString(),
                        rol = lector["rol"].ToString()
                    };
                    return usuario1;

                }


                return null;


            }catch(SqlException ex)
            {
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Login");
                return null;
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
