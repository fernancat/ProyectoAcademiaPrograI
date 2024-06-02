using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EDUCATIVE.Models;

namespace EDUCATIVE.DAOModels
{
    public class GruposDAO
    {
        private string cadenaConexion = Models.BaseDeDatoscs.cadenaConexion;

        public List<Grupo> ObtenerGruposPorCurso(int cursoID)
        {
            List<Grupo> grupos = new List<Grupo>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM grupos WHERE curso_id = @CursoID";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@CursoID", cursoID);

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Grupo grupo = new Grupo
                        {
                            Id = Convert.ToInt32(lector["id"]),
                            Nombre = lector["nombre"].ToString(),
                            CursoId = Convert.ToInt32(lector["curso_id"])
                        };

                        grupos.Add(grupo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los grupos: " + ex.Message);
            }

            return grupos;
        }

        public bool CrearGrupo(string nombre, int cursoID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO grupos (nombre, curso_id) VALUES (@Nombre, @CursoID)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@CursoID", cursoID);

                    int filasInsertadas = comando.ExecuteNonQuery();
                    return filasInsertadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el grupo: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarGrupo(int id, string nombre, int cursoID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE grupos SET nombre = @Nombre, curso_id = @CursoID WHERE id = @Id";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@CursoID", cursoID);
                    comando.Parameters.AddWithValue("@Id", id);

                    int filasActualizadas = comando.ExecuteNonQuery();
                    return filasActualizadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el grupo: " + ex.Message);
                return false;
            }
        }

        public bool EliminarGrupo(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM grupos WHERE id = @Id";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Id", id);

                    int filasEliminadas = comando.ExecuteNonQuery();
                    return filasEliminadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el grupo: " + ex.Message);
                return false;
            }
        }
    }
}
