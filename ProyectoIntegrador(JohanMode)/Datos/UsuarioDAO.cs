using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace ProyectoIntegrador_JohanMode_.Datos
{

    public class UsuarioDAO
    {
        // 1. ACTUALIZADO: Cambiado 'localhost' por tu servidor real 'JOHAN' para asegurar la conexión
        private string conexionString = @"Server=JOHAN;Database=ProyectoIntegradorV1;Trusted_Connection=True;TrustServerCertificate=True;";

        // === MÉTODO 1: REGISTRAR UN USUARIO NUEVO ===
        public bool RegistrarUsuario(string nombre, string correo, string contrasena, string grupo)
        {
            // Nota: Si en el futuro agregas la columna 'IdGrupo' a tu tabla 'USUARIOS',
            // recuerda incluirla en este INSERT.
            string query = "INSERT INTO USUARIOS (Nombre, Correo, Contraseña, FechaRegistro) " +
                           "VALUES (@Nombre, @Correo, @Contraseña, @FechaRegistro)";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contrasena);
                    cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

                    try
                    {
                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("ERROR REAL: " + ex.Message, "Detalle del Error");
                        return false;
                    }
                }
            }
        }

        // === MÉTODO 2: VALIDAR EL INICIO DE SESIÓN (ACTUALIZADO) ===
        public bool ValidarUsuario(string correo, string contrasena)
        {
            // 2. ACTUALIZADO: En lugar de un COUNT, traemos los datos clave del alumno (ID, Nombre y Grupo)
            // Nota: Si tu columna de grupo en la base de datos se llama diferente a 'IdGrupo', cámbiala aquí.
            string query = "SELECT IdUsuario, Nombre, IdGrupo FROM USUARIOS WHERE Correo = @Correo AND Contraseña = @Contraseña";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contrasena);

                    try
                    {
                        con.Open();
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                // 3. ACTUALIZADO: Almacenamos los datos en la sesión global para que 
                                // FormContenidoMateria sepa a quién pertenece la entrega y qué tareas mostrar.
                                Sesion.IdUsuario = Convert.ToInt32(lector["IdUsuario"]);
                                Sesion.NombreUsuario = lector["Nombre"].ToString();

                                // Manejo de nulos por si el usuario recién registrado aún no tiene grupo asignado
                                Sesion.IdGrupo = lector["IdGrupo"] != DBNull.Value ? Convert.ToInt32(lector["IdGrupo"]) : 0;

                                return true; // Login exitoso y sesión iniciada
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("ERROR REAL EN LOGIN: " + ex.Message, "Detalle del Error");
                        return false;
                    }
                }
            }
            return false; // Credenciales incorrectas
        }
    }
}
