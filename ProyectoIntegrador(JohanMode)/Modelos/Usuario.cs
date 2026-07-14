using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }

        public string Grupo { get; set; }
    }
}