using EDUCATIVE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.DAOModels
{
    public class CursosDAOcs
    {
        private string cadenaDeConexion = BaseDeDatoscs.cadenaConexion;


        public bool CrearCurso(string titulo, string descripcion, byte[] imagenCurso)
        {

            SqlConnection conexion = new SqlConnection(cadenaDeConexion);

            try
            {
                conexion.Open();
                string consulta = "INSERT INTO cursos(titulo, descripcion, imagen)" +
                    "VALUES (@Titulo, @Descripcion, @Imagen)";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Titulo", titulo);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Imagen", imagenCurso);

                int filasInsertadas = comando.ExecuteNonQuery();
                return filasInsertadas > 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }
        public List<Curso> ObtenerCursosDisponibles()
        {
            List<Curso> cursos = new List<Curso>();
            SqlConnection conexion = new SqlConnection(cadenaDeConexion);
            try
            {
                conexion.Open();
                string consulta = "SELECT id, titulo, descripcion, imagen FROM cursos";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Curso curso = new Curso
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        Titulo = lector["titulo"].ToString(),
                        Descripcion = lector["descripcion"].ToString(),
                        ImagenCurso = (byte[])lector["imagen"]
                    };
                    cursos.Add(curso);
                }
                return cursos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cursos: " + ex.Message);
                return null;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}

