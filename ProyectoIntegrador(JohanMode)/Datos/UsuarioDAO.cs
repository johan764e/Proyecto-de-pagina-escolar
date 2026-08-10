using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
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
            // Cambiado RutaFoto por FotoPerfil para coincidir exacto con tu diagrama
            string query = "SELECT IdUsuario, Nombre, IdGrupo, FotoPerfil FROM USUARIOS WHERE Correo = @Correo AND Contraseña = @Contraseña";

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
                                Sesion.IdUsuario = Convert.ToInt32(lector["IdUsuario"]);
                                Sesion.NombreUsuario = lector["Nombre"].ToString();
                                Sesion.IdGrupo = lector["IdGrupo"] != DBNull.Value ? Convert.ToInt32(lector["IdGrupo"]) : 0;

                                // Lee la columna FotoPerfil de la BD
                                Sesion.FotoPerfil = CargarFotoPerfil(lector["FotoPerfil"]);

                                return true;
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

            return false;
        }

        private Image CargarFotoPerfil(object valorRutaFoto)
        {
            string rutaFotoBD = valorRutaFoto != DBNull.Value ? valorRutaFoto.ToString() : "";

            if (!string.IsNullOrEmpty(rutaFotoBD) && File.Exists(rutaFotoBD))
            {
                try
                {
                    // Carga la foto sin bloquear el archivo original
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(rutaFotoBD)))
                    {
                        return Image.FromStream(ms);
                    }
                }
                catch
                {
                    return CargarFotoDefecto();
                }
            }

            return CargarFotoDefecto();
        }

        private Image CargarFotoDefecto()
        {
            try
            {
                // Busca la imagen directamente dentro del directorio de compilación generado por Visual Studio
                string rutaRelativa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recursos", "Iconografia", "imagengenericapng.png");

                if (File.Exists(rutaRelativa))
                {
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(rutaRelativa)))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch { }

            return null;
        }
    }
}