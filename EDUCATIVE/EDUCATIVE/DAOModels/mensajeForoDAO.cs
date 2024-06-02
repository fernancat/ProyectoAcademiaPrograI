using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EDUCATIVE.Models;

namespace EDUCATIVE.DAOModels
{
    public class MensajeForoDAO
    {
        public string cadenaConexion = BaseDeDatoscs.cadenaConexion;

        public bool CrearMensajeForo(int foroId, string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "INSERT INTO mensajes_foro(foro_id, mensaje) VALUES(@ForoId, @Mensaje)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ForoId", foroId);
                        comando.Parameters.AddWithValue("@Mensaje", mensaje);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Mensaje creado correctamente.");
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

        public bool ActualizarMensajeForo(int idMensaje, string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "UPDATE mensajes_foro SET mensaje = @Mensaje WHERE id = @IDMensaje";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Mensaje", mensaje);
                        comando.Parameters.AddWithValue("@IDMensaje", idMensaje);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Mensaje actualizado correctamente.");
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

        public bool BorrarMensajeForo(int idMensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM mensajes_foro WHERE id = @IDMensaje";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDMensaje", idMensaje);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Mensaje borrado correctamente.");
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

        public List<MensajeForo> ObtenerMensajesForo(int foroId)
        {
            List<MensajeForo> mensajesForo = new List<MensajeForo>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT id, foro_id, mensaje FROM mensajes_foro WHERE foro_id = @ForoId";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ForoId", foroId);

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            MensajeForo mensaje = new MensajeForo
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                foro_id = reader.GetInt32(reader.GetOrdinal("foro_id")),
                                mensaje = reader.GetString(reader.GetOrdinal("mensaje"))
                            };

                            mensajesForo.Add(mensaje);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return mensajesForo;
        }
    }
}
