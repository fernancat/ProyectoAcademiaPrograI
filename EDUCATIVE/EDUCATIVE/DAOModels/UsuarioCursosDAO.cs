using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EDUCATIVE.DAOModels
{
    public class UsuariosCursosDAO
    {
        private string cadenaDeConexion = Models.BaseDeDatoscs.cadenaConexion;

        public bool InscribirUsuarioACurso(int idUsuario, int idCurso)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    string consulta = "INSERT INTO UsuariosCursos (IdUsuario, IdCurso) VALUES (@IdUsuario, @IdCurso)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@IdCurso", idCurso);

                    int filasInsertadas = comando.ExecuteNonQuery();
                    return filasInsertadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public bool EstaInscrito(int idUsuario, int idCurso)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM UsuariosCursos WHERE IdUsuario = @IdUsuario AND IdCurso = @IdCurso";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@IdCurso", idCurso);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
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
