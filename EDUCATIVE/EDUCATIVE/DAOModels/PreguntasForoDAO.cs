using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EDUCATIVE.Models;

namespace EDUCATIVE.DAOModels
{
    public class PreguntaForoDAO
    {
        public string cadenaConexion = BaseDeDatoscs.cadenaConexion;

        public bool CrearPreguntaForo(int foroId, string pregunta)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO preguntas_foro(foro_id, pregunta) VALUES(@ForoId, @Pregunta)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ForoId", foroId);
                        comando.Parameters.AddWithValue("@Pregunta", pregunta);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pregunta creada correctamente.");
                            return true;
                        }
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

        public bool ActualizarPreguntaForo(int idPregunta, string pregunta)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "UPDATE preguntas_foro SET pregunta = @Pregunta WHERE id = @IDPregunta";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Pregunta", pregunta);
                        comando.Parameters.AddWithValue("@IDPregunta", idPregunta);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pregunta actualizada correctamente.");
                            return true;
                        }
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

        public bool BorrarPreguntaForo(int idPregunta)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM preguntas_foro WHERE id = @IDPregunta";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDPregunta", idPregunta);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pregunta borrada correctamente.");
                            return true;
                        }
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

        public List<PreguntaForo> ObtenerPreguntasForo(int foroId)
        {
            List<PreguntaForo> preguntasForo = new List<PreguntaForo>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT id, foro_id, pregunta FROM preguntas_foro WHERE foro_id = @ForoId";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ForoId", foroId);

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            PreguntaForo pregunta = new PreguntaForo
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                foro_id = reader.GetInt32(reader.GetOrdinal("foro_id")),
                                pregunta = reader.GetString(reader.GetOrdinal("pregunta"))
                            };

                            preguntasForo.Add(pregunta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return preguntasForo;
        }
    }
}
