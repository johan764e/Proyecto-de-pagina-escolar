using System;
using System.Collections.Generic;
using ProyectoIntegrador_JohanMode_.Modelos;

namespace ProyectoIntegrador_JohanMode_.Datos
{
    public static class AvisoRepository
    {
        public static List<Aviso> ObtenerAvisos()
        {
            return new List<Aviso>
            {
                new Aviso
                {
                    Id = 1,
                    Titulo = "Matematicas",
                    Fecha = DateTime.Now.AddDays(-1),
                    Contenido = "Realizar los problemas impares de las siguientes Integrales Indefinidas."
                },
                new Aviso
                {
                    Id = 2,
                    Titulo = "Programacion Orientada a objetos",
                    Fecha = DateTime.Now.AddDays(-3),
                    Contenido = "En esta asignación deberán de subir los requisitos del segundo entregable para su debida revisión."
                },
                new Aviso
                {
                    Id = 3,
                    Titulo = "Ingles II",
                    Fecha = DateTime.Now.AddDays(-5),
                    Contenido = "Vocabulary Comparatives."
                },
                new Aviso
                {
                    Id = 4,
                    Titulo = "Examen",
                    Fecha = DateTime.Now.AddDays(-7),
                    Contenido = "Examen pendiente para el 10 de junio."
                }
            };
        }
    }
}