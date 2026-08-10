using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador_JohanMode_.Datos
{
    // La clase debe ser "static" para que mantenga los datos guardados en toda la app
    public static class Sesion
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static int IdGrupo { get; set; }
        public static Image FotoPerfil { get; set; }

        // Método opcional para limpiar la sesión al cerrar sesión
        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            IdGrupo = 0;
        }
    }
}
