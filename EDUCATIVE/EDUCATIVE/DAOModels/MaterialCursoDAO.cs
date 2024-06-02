using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EDUCATIVE.DAOModels
{
    public class MaterialCursoDAO
    {
        private string cadenaConexion = BaseDeDatoscs.cadenaConexion;

        public bool AgregarMaterialCurso(int idCurso, string tipo, string contenido)
        {
            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string consulta = "INSERT INTO materiales_curso(curso_id, tipo, contenido) " +
                        "VALUES(@Curso_id, @Tipo, @Contenido)";

                    using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                    {
                        comando.Parameters.AddWithValue("@Curso_id", idCurso);
                        comando.Parameters.AddWithValue("@Tipo", tipo);
                        comando.Parameters.AddWithValue("@Contenido", contenido);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public bool EditarMaterialCurso(int id, string tipo, string contenido)
        {
            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string consulta = "UPDATE materiales_curso SET tipo = @Tipo, contenido = @Contenido WHERE id = @Id";

                    using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                    {
                        comando.Parameters.AddWithValue("@Tipo", tipo);
                        comando.Parameters.AddWithValue("@Contenido", contenido);
                        comando.Parameters.AddWithValue("@Id", id);

                        int filasEditadas = comando.ExecuteNonQuery();

                        if (filasEditadas > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {                    
                    return false;
                }
            }
        }

        public List<MaterialCurso> ObtenerMaterialesCurso(int idCurso)
        {
            List<MaterialCurso> materiales = new List<MaterialCurso>();

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string consulta = "SELECT * FROM materiales_curso WHERE curso_id = @idCurso";

                    using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                    {
                        comando.Parameters.AddWithValue("@idCurso", idCurso);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MaterialCurso material = new MaterialCurso
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                                    idCurso = reader.GetInt32(reader.GetOrdinal("curso_id")),
                                    tipo = reader.GetString(reader.GetOrdinal("tipo")),
                                    contenido = reader.GetString(reader.GetOrdinal("contenido"))
                                };
                                materiales.Add(material);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return materiales;
        }
        public bool BorrarMaterialCurso(int idMaterial)
        {
            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    sqlConnection.Open();

                    string consulta = "DELETE FROM materiales_curso WHERE id = @Id";

                    using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                    {
                        comando.Parameters.AddWithValue("@Id", idMaterial);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return true; 
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }

    
   
}
