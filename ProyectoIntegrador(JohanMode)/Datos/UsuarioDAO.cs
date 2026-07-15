using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador_JohanMode_.Datos
{

    public class UsuarioDAO
    {
        // Reemplaza esto con tu cadena de conexión real a tu servidor2 de SQL Server
        private string conexionString = @"Server=localhost;Database=ProyectoIntegradorV1;Trusted_Connection=True;TrustServerCertificate=True;";  

        // === MÉTODO 1: REGISTRAR UN USUARIO NUEVO ===
        public bool RegistrarUsuario(string nombre, string correo, string contrasena, string grupo)
            {
                // Tu tabla USUARIOS del diagrama no tiene columna Grupo, de modo que lo guardamos de forma local.
                // Si después agregas la columna "Grupo" a la tabla, agrégala también en este query.
                string query = "INSERT INTO USUARIOS (Nombre, Correo, Contraseña, FechaRegistro) " +
                               "VALUES (@Nombre, @Correo, @Contraseña, @FechaRegistro)";

                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contrasena);
                        cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now); // Asigna la fecha actual al registrarse

                        try
                        {
                            con.Open();
                            int filasAfectadas = cmd.ExecuteNonQuery();
                            return filasAfectadas > 0; // Si es mayor a 0, se insertó correctamente
                        }
                    catch (Exception ex)
                    {
                        // Esto te dirá exactamente por qué no se conecta a tu servidor local
                        System.Windows.Forms.MessageBox.Show("ERROR REAL: " + ex.Message, "Detalle del Error");
                        return false;
                    }
                }
                }
            }

            // === MÉTODO 2: VALIDAR EL INICIO DE SESIÓN ===
            public bool ValidarUsuario(string correo, string contrasena)
            {
                string query = "SELECT COUNT(1) FROM USUARIOS WHERE Correo = @Correo AND Contraseña = @Contraseña";

                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contrasena);

                        try
                        {
                            con.Open();
                            int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                            return resultado == 1; // Retorna true si encontró una coincidencia exacta
                        }
                    catch (Exception ex)
                    {
                        // Esto te dirá exactamente por qué no se conecta a tu servidor local
                        System.Windows.Forms.MessageBox.Show("ERROR REAL: " + ex.Message, "Detalle del Error");
                        return false;
                    }
                }
                }
            }

    }
}
