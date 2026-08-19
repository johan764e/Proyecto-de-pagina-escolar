using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;

namespace ProyectoIntegrador.Datos
{
    public class Conexion
    {
        private readonly string cadena =
            @"Server=JOHAN;
              Database=ProyectoIntegrador;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
