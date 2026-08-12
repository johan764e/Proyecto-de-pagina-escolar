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
        // Se declara la cadena de conexión a la base de datos
        private string conexionString = @"Server=JOHAN;Database=ProyectoIntegradorV1;Trusted_Connection=True;TrustServerCertificate=True;";

        // Esta parte registra un usuario nuevo guardando también si es Alumno o Profesor
        public bool RegistrarUsuario(string nombre, string correo, string contrasena, string grupo, string rol)
        {
            // Se agrega el campo Rol en la consulta para guardarlo en la base de datos
            string query = "INSERT INTO USUARIOS (Nombre, Correo, Contraseña, FechaRegistro, Rol) " +
                           "VALUES (@Nombre, @Correo, @Contraseña, @FechaRegistro, @Rol)";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contrasena);
                    cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Rol", rol); // Guarda si es Alumno o Profesor

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

        // Esta parte valida el correo y contraseña, y trae el Rol para guardarlo en la Sesion
        public bool ValidarUsuario(string correo, string contrasena)
        {
            // Se agrega el campo Rol en la consulta SQL
            string query = "SELECT IdUsuario, Nombre, IdGrupo, FotoPerfil, Rol FROM USUARIOS WHERE Correo = @Correo AND Contraseña = @Contraseña";

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

                                // Asigna el rol obtenido de la base de datos a la clase Sesion
                                Sesion.Rol = lector["Rol"] != DBNull.Value ? lector["Rol"].ToString() : "Alumno";

                                // Carga la foto guardada
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

        // Esta parte busca y carga la foto de perfil en la ruta
        private Image CargarFotoPerfil(object valorRutaFoto)
        {
            string rutaFotoBD = valorRutaFoto != DBNull.Value ? valorRutaFoto.ToString() : "";

            if (!string.IsNullOrEmpty(rutaFotoBD) && File.Exists(rutaFotoBD))
            {
                try
                {
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

        // Esta parte carga la imagen genérica si el usuario no tiene foto
        private Image CargarFotoDefecto()
        {
            try
            {
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