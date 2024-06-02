using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.DAOModels
{
    public class usuarioDAO
    {
        private string cadenaConexion = Models.BaseDeDatoscs.cadenaConexion;



        public bool EditarPerfil(int IdUsuario, string nuevoNombre, string nuevosApellidos, string nuevoEmail, byte[] fotoPerfilBytes)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                string consulta = "UPDATE usuarios SET nombre = @NuevoNombre, apellidos = @NuevosApellidos, email = @NuevoEmail, foto_perfil = @FotoPerfil WHERE id = @IdUsuario ";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                comando.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                comando.Parameters.AddWithValue("@NuevosApellidos", nuevosApellidos);
                comando.Parameters.AddWithValue("@NuevoEmail", nuevoEmail);
                comando.Parameters.AddWithValue("@FotoPerfil", fotoPerfilBytes);

                int filasActualizadas = comando.ExecuteNonQuery();

                return filasActualizadas > 0;

            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            Usuario usuario = null;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                string consulta = "SELECT * FROM usuarios WHERE id = @IdUsuario";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    usuario = new Usuario
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        nombre_usuario = lector["nombre"].ToString(),
                        apellidos = lector["apellidos"].ToString(),
                        email = lector["email"].ToString(),
                        FotoPerfil = lector["foto_perfil"] as byte[],
                        contraseña = lector["contrasena"].ToString(),
                        rol = lector["rol"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return usuario;
        }
    }
}
