using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUCATIVE.Models;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace EDUCATIVE.DAOModels

{
   class auhentication()
    {
        private string conexion = Models.BaseDeDatoscs.cadenaConexion;
        private SqlConnection sqlConnection;
        
        

        public Usuario LoguearUsuario(string correo, string contraseña, Form formularioActual)
        {
            sqlConnection = new SqlConnection(conexion);
            try
            {
                sqlConnection.Open();
                

                string consulta = "SELECT * FROM usuarios WHERE email =@Email AND contrasena = @contraseña";
                SqlCommand comando = new SqlCommand(consulta, sqlConnection);
                comando.Parameters.AddWithValue("@Email", correo);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                SqlDataReader lector = comando.ExecuteReader();
               
                
                if (lector.Read())
                {
 
                    MessageBox.Show("Has iniciado sesion correctamente");
                    Usuario usuario1 = new Usuario
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        nombre_usuario = lector["nombre"].ToString(),
                        apellidos = lector["apellidos"].ToString(),
                        email = lector["email"].ToString(),
                        contraseña = lector["contrasena"].ToString(),
                        FotoPerfil = (byte[])lector["foto_perfil"],
                        rol = lector["rol"].ToString()
                    };
                    return usuario1;

                }


                return null;


            }catch(SqlException ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex);

                return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex);

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

        public Usuario registrarUsuario(string nombre, string apellidos, string email, string contraseña,string rol) 
        {
            sqlConnection = new SqlConnection(conexion);
            try
            {
                sqlConnection.Open();
                string consulta = "INSERT INTO usuarios (nombre, apellidos, email, contrasena, rol)" +
                    "VALUES (@Nombre, @Apellidos, @Email, @Contrasena, @Rol);" + "SELECT SCOPE_IDENTITY()";

                SqlCommand comando = new SqlCommand(consulta, sqlConnection);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellidos", apellidos);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Contrasena", contraseña);
                comando.Parameters.AddWithValue("@Rol", rol);
                int lastInsertedId = Convert.ToInt32(comando.ExecuteScalar());




                // Obtener el último ID insertado


                // Crear un objeto Usuario con los datos del usuario registrado
                Usuario usuarioRegistrado = new Usuario
                {
                    Id = lastInsertedId,
                    nombre_usuario = nombre,
                    apellidos = apellidos,
                    email = email,
                    contraseña = contraseña,
                    rol = rol
                };

                return usuarioRegistrado;
                


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error en la base de datos" + ex);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Login");
                MessageBox.Show(ex + "");
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
