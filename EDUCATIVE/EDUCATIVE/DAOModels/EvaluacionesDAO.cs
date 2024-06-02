using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDevHtmlRenderer.Core.Handlers;

namespace EDUCATIVE.DAOModels
{
    public class EvaluacionesDAO
    {
        public string cadenaConexion = BaseDeDatoscs.cadenaConexion;
        public List<Evaluaciones> evaluaciones;
        
        
        public bool CrearEvaluacion(int cursoID, string titulo, string descripcion)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO evaluaciones(curso_id, titulo, descripcion)" +
                        "VALUES(@CursoID, @Titulo, @Descripcion)";


                   using(SqlCommand comandoConsulta = new SqlCommand(consulta, conexion)){

                        comandoConsulta.Parameters.AddWithValue("@CursoID", cursoID);
                        comandoConsulta.Parameters.AddWithValue("@Titulo", titulo);
                        comandoConsulta.Parameters.AddWithValue("@Descripcion", descripcion);

                        int filasAfectadas = comandoConsulta.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Evaluacion creada");
                            return true;
                        }
                        MessageBox.Show("Hubo un error al crear la evaluacion");
                        return false;
                    }
                        

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


           

        }
        public bool ActualizarEvaluacion(int idEvaluacion, string titulo, string descripcion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE evaluaciones SET titulo =@Titulo, descripcion = @Descripcion WHERE id = @IdEval";
                    
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Titulo", titulo);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion);
                        comando.Parameters.AddWithValue("@IdEval", idEvaluacion);

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Evaluacion Actualizada Correctamente");
                            return true;
                        }

                        return false;
                    }

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Evaluaciones> ObtenerEvaluaciones(int idCurso)
        {
            evaluaciones = new List<Evaluaciones> { };  
            try
            {
                using(SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    sqlConnection.Open();
                    string consulta = "SELECT * FROM evaluaciones WHERE curso_id = @IDCurso";

                    using(SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                    {
                        comando.Parameters.AddWithValue("@IDCurso", idCurso);

                        SqlDataReader lector = comando.ExecuteReader();

                        while (lector.Read())
                        {
                            Evaluaciones evaluacion = new Evaluaciones
                            {
                                id = lector.GetInt32(lector.GetOrdinal("id")),
                                curso_id = lector.GetInt32(lector.GetOrdinal("curso_id")),
                                titulo = lector.GetString(lector.GetOrdinal("titulo")),
                                descripcion = lector.GetString(lector.GetOrdinal("descripcion"))
                            };
                            evaluaciones.Add(evaluacion);
                            
                        }
                        return evaluaciones;
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool borrarEvaluacion(int idEvaluacion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string consultaPruebas = "DELETE FROM pruebas WHERE evaluacion_id = @IDEvaluacion";
                            using (SqlCommand comandoPruebas = new SqlCommand(consultaPruebas, conexion, transaccion))
                            {
                                comandoPruebas.Parameters.AddWithValue("@IDEvaluacion", idEvaluacion);
                                comandoPruebas.ExecuteNonQuery();
                            }

                            string consultaEvaluaciones = "DELETE FROM evaluaciones WHERE id = @IDEvaluacion";
                            using (SqlCommand comandoEvaluaciones = new SqlCommand(consultaEvaluaciones, conexion, transaccion))
                            {
                                comandoEvaluaciones.Parameters.AddWithValue("@IDEvaluacion", idEvaluacion);
                                int filasAfectadas = comandoEvaluaciones.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    transaccion.Commit();
                                    MessageBox.Show("Evaluacion Eliminada");
                                    return true;
                                }
                                else
                                {
                                    transaccion.Rollback();
                                    MessageBox.Show("No se encontró la evaluación para eliminar");
                                    return false;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            transaccion.Rollback();
                            throw; 
                        }
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
