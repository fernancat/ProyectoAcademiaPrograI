using EDUCATIVE.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.DAOModels
{
    public class ForoDAOcs
    {
        public string cadenaConexion = BaseDeDatoscs.cadenaConexion;
        List<ForosModel> foros;



        public bool CrearForo(int idCurso, string titulo, string descripcion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO foros(curso_id, titulo, descripcion) VALUES(@IDCurso, @Titulo, @Descripcion)";

                    using (SqlCommand sqlcommand = new SqlCommand(consulta, conexion)) { 
                    
                        sqlcommand.Parameters.AddWithValue("@IDCurso", idCurso);
                        sqlcommand.Parameters.AddWithValue("@Titulo", titulo);
                        sqlcommand.Parameters.AddWithValue("Descripcion", descripcion);

                        int filasAfectdas = sqlcommand.ExecuteNonQuery();

                        if (filasAfectdas > 0)
                        {
                            MessageBox.Show("Se creo el foro correctamente");
                            return true;
                        }
                        return false;
                    } 
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool ActualizarForo(int idForo, string titulo, string descripcion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE foros SET titulo = @Titulo, descripcion = @Descripcion WHERE id = @IDForo ";

                    using(SqlCommand command = new SqlCommand(consulta, conexion))
                    {
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("IDForo", idForo);

                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Foro Correctamente Actualizado");
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


        public bool borrarForo(int idForo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion)) {

                    conexion.Open();

                    string consulta = "DELETE FROM foros WHERE id = @IDForo";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDForo", idForo);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Se borro el foro correctamente");
                            return true;
                        }
                        return false;
                    }
                }

            }
            catch(Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message);
            }
        }


        public List<ForosModel> ObtenerForos(int idCurso)
        {
            foros = new List<ForosModel> { };
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM foros WHERE curso_id = @IDCurso";
                    using (SqlCommand command = new SqlCommand(consulta, conexion))
                    {
                        command.Parameters.AddWithValue("@IDCurso", idCurso);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ForosModel foro = new ForosModel
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                idCurso = reader.GetInt32(reader.GetOrdinal("curso_id")),
                                titulo = reader.GetString(reader.GetOrdinal("titulo")),
                                descripcion = reader.GetString(reader.GetOrdinal("descripcion"))
                                
                            };

                            foros.Add(foro);
                        }
                        return foros;

                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
