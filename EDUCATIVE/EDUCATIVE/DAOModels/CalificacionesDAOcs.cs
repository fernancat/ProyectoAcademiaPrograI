using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EDUCATIVE.DAOModels
{
    public class CalificacionesDAO
    {
        private string cadenaConexion = Models.BaseDeDatoscs.cadenaConexion;

        public List<Calificacion> ObtenerCalificaciones(int idUsuario)
        {
            List<Calificacion> calificaciones = new List<Calificacion>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM calificaciones WHERE usuario_id = @IdUsuario";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Calificacion calificacion = new Calificacion
                        {
                            Id = Convert.ToInt32(lector["id"]),
                            IdUsuario = Convert.ToInt32(lector["usuario_id"]),
                            IdCurso = Convert.ToInt32(lector["curso_id"]),
                            CalificacionValor = Convert.ToInt32(lector["calificacion"]),
                            Comentarios = lector["comentarios"].ToString()
                        };

                        calificaciones.Add(calificacion);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las calificaciones: " + ex.Message);
            }

            return calificaciones;
        }

        public bool ActualizarCalificacion(Calificacion calificacion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE calificaciones SET calificacion = @Calificacion, comentarios = @Comentarios WHERE id = @Id";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Calificacion", calificacion.CalificacionValor);
                    comando.Parameters.AddWithValue("@Comentarios", calificacion.Comentarios);
                    comando.Parameters.AddWithValue("@Id", calificacion.Id);

                    int filasActualizadas = comando.ExecuteNonQuery();
                    return filasActualizadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la calificación: " + ex.Message);
                return false;
            }
        }

        public List<Calificacion> ObtenerCalificacionesPorCurso(int idCurso)
        {
            List<Calificacion> calificaciones = new List<Calificacion>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM calificaciones WHERE curso_id = @IdCurso";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdCurso", idCurso);

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Calificacion calificacion = new Calificacion
                        {
                            Id = Convert.ToInt32(lector["id"]),
                            IdUsuario = Convert.ToInt32(lector["usuario_id"]),
                            IdCurso = Convert.ToInt32(lector["curso_id"]),
                            CalificacionValor = Convert.ToInt32(lector["calificacion"]),
                            Comentarios = lector["comentarios"].ToString()
                        };

                        calificaciones.Add(calificacion);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las calificaciones: " + ex.Message);
            }

            return calificaciones;
        }

        public Calificacion ObtenerCalificacionPorUsuarioYCurso(int idUsuario, int idCurso)
        {
            Calificacion calificacion = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM calificaciones WHERE usuario_id = @IdUsuario AND curso_id = @IdCurso";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@IdCurso", idCurso);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        calificacion = new Calificacion
                        {
                            Id = Convert.ToInt32(lector["id"]),
                            IdUsuario = Convert.ToInt32(lector["usuario_id"]),
                            IdCurso = Convert.ToInt32(lector["curso_id"]),
                            CalificacionValor = Convert.ToInt32(lector["calificacion"]),
                            Comentarios = lector["comentarios"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la calificación: " + ex.Message);
            }

            return calificacion;
        }

        public bool CrearCalificacion(int usuarioID, int cursoID, int calificacion, string comentarios)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO calificaciones (usuario_id, curso_id, calificacion, comentarios) VALUES (@UsuarioId, @CursoId, @Calificacion, @Comentarios)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@UsuarioId", usuarioID);
                    comando.Parameters.AddWithValue("@CursoId", cursoID);
                    comando.Parameters.AddWithValue("@Calificacion", calificacion);
                    comando.Parameters.AddWithValue("@Comentarios", comentarios);

                    int filasInsertadas = comando.ExecuteNonQuery();
                    return filasInsertadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la calificación: " + ex.Message);
                return false;
            }
        }
    }

}
