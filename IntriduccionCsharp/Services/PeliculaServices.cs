using IntriduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IntriduccionCsharp.Services
{
    public class PeliculaServices
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 120,
                Pais = "USA",
                Publicacion = new DateTime(2023, 12, 5)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 111,
                Pais = "USA",
                Publicacion = new DateTime(2015, 05, 5)
            };
            return new List<Pelicula>{ pelicula1, pelicula2 };
        }
    }
}