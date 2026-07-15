using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador_JohanMode_.Datos
{

    public class UsuarioDAO
    {
 
            private string conexionString = "Server=TU_SERVIDOR;Database=TU_BASE_DATOS;Trusted_Connection=True;";

            // Agregamos el parámetro grupo
            public bool RegistrarUsuario(string nombre, string correo, string contrasena, string grupo)
            {
                // NOTA: Si en tu base de datos agregas la columna Grupo a la tabla USUARIOS, 
                // agrégala también aquí en el INSERT. Por ahora, lo dejamos listo:
                string query = "INSERT INTO USUARIOS (Nombre, Correo, Contrasena, FechaRegistro) " +
                               "VALUES (@Nombre, @Correo, @Contrasena, @FechaRegistro)";

                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                        // cmd.Parameters.AddWithValue("@Grupo", grupo); // Descoméntalo si añades la columna Grupo a la BD

                        try
                        {
                            con.Open();
                            int filasAfectadas = cmd.ExecuteNonQuery();
                            return filasAfectadas > 0;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine("Error de BD: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
        }
     }
