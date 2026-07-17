using Microsoft.Data.SqlClient;
using ProyectoIntegrador.Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador_JohanMode_.Datos
{
    public class TareaDAO
    {
        private Conexion conexion = new Conexion();

        // Método para obtener la tarea pendiente según materia y grupo
        public Tarea ObtenerTareaPendiente(int idMateria, int idGrupo)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string query = "SELECT TOP 1 Titulo, Descripcion FROM Tareas " +
                               "WHERE IdMateria = @IdMateria AND IdGrupo = @IdGrupo " +
                               "ORDER BY IdTarea DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdMateria", idMateria);
                    cmd.Parameters.AddWithValue("@IdGrupo", idGrupo);

                    try
                    {
                        con.Open();
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Tarea
                                {
                                    Titulo = lector["Titulo"].ToString(),
                                    Descripcion = lector["Descripcion"].ToString()
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al cargar la tarea: " + ex.Message);
                    }
                }
            }
            return null; // Si no hay tareas pendientes
        }

        // Método para registrar la entrega de la tarea
        public bool InsertarEntrega(int idMateria, int idUsuario, string titulo, string descripcion, string rutaArchivo)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Entregas (IdMateria, IdUsuario, Titulo, Descripcion, RutaArchivo, FechaEntrega) " +
                               "VALUES (@IdMateria, @IdUsuario, @Titulo, @Descripcion, @RutaArchivo, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdMateria", idMateria);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@RutaArchivo", string.IsNullOrEmpty(rutaArchivo) ? (object)DBNull.Value : rutaArchivo);

                    try
                    {
                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al guardar la entrega: " + ex.Message);
                    }
                }
            }
        }
    }

    // Clase auxiliar simple para transportar los datos de la tarea
    public class Tarea
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
}
