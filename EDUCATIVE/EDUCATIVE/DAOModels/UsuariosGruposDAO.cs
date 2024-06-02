using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EDUCATIVE.Models;

namespace EDUCATIVE.DAOModels
{
    public class UsuariosGruposDAO
    {
        private string cadenaConexion = Models.BaseDeDatoscs.cadenaConexion;

        public List<Usuario> ObtenerUsuariosPorGrupo(int grupoId)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT u.* FROM usuarios u INNER JOIN usuarios_grupos ug ON u.id = ug.usuario_id WHERE ug.grupo_id = @GrupoId";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@GrupoId", grupoId);

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            Id = Convert.ToInt32(lector["id"]),
                            nombre_usuario = lector["nombre"].ToString(),
                            // Asignar otros campos según el modelo Usuario
                        };

                        usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios del grupo: " + ex.Message);
            }

            return usuarios;
        }
        public bool AsignarUsuarioAGrupo(int usuarioID, int grupoID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO usuarios_grupos (usuario_id, grupo_id) VALUES (@UsuarioID, @GrupoID)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    comando.Parameters.AddWithValue("@GrupoID", grupoID);

                    int filasInsertadas = comando.ExecuteNonQuery();
                    return filasInsertadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar usuario al grupo: " + ex.Message);
                return false;
            }
        }
    }
}

