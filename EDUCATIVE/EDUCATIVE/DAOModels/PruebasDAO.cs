using EDUCATIVE.Models;
using System.Data.SqlClient;

public class PruebasDAO
{
    public string cadenaConexion = BaseDeDatoscs.cadenaConexion;
    public List<Pruebas> pruebas;

    public PruebasDAO()
    {
        pruebas = new List<Pruebas>();
    }

    public bool CrearPrueba(int evaluacionID, string pregunta, string respuestaCorrecta)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "INSERT INTO pruebas(evaluacion_id, pregunta, respuesta_correcta) " +
                                  "VALUES(@EvaluacionID, @Pregunta, @RespuestaCorrecta)";

                using (SqlCommand comandoConsulta = new SqlCommand(consulta, conexion))
                {
                    comandoConsulta.Parameters.AddWithValue("@EvaluacionID", evaluacionID);
                    comandoConsulta.Parameters.AddWithValue("@Pregunta", pregunta);
                    comandoConsulta.Parameters.AddWithValue("@RespuestaCorrecta", respuestaCorrecta);

                    int filasAfectadas = comandoConsulta.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Prueba creada");
                        return true;
                    }
                    MessageBox.Show("Hubo un error al crear la prueba");
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

    public bool ActualizarPrueba(int idPrueba, string pregunta, string respuestaCorrecta)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE pruebas SET pregunta = @Pregunta, respuesta_correcta = @RespuestaCorrecta WHERE id = @IdPrueba";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Pregunta", pregunta);
                    comando.Parameters.AddWithValue("@RespuestaCorrecta", respuestaCorrecta);
                    comando.Parameters.AddWithValue("@IdPrueba", idPrueba);

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Prueba actualizada correctamente");
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

    public List<Pruebas> ObtenerPruebas(int evaluacionID)
    {
        pruebas = new List<Pruebas>();
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();
                string consulta = "SELECT * FROM pruebas WHERE evaluacion_id = @EvaluacionID";

                using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@EvaluacionID", evaluacionID);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Pruebas prueba = new Pruebas
                            {
                                id = lector.GetInt32(lector.GetOrdinal("id")),
                                evaluacion_id = lector.GetInt32(lector.GetOrdinal("evaluacion_id")),
                                pregunta = lector.GetString(lector.GetOrdinal("pregunta")),
                                respuesta_correcta = lector.GetString(lector.GetOrdinal("respuesta_correcta"))
                            };
                            pruebas.Add(prueba);
                        }
                        return pruebas;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return null;
        }
    }

    public bool BorrarPrueba(int idPrueba)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "DELETE FROM pruebas WHERE id = @IdPrueba";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdPrueba", idPrueba);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Prueba eliminada");
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
}
