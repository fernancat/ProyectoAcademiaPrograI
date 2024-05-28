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
        }
    }
}
