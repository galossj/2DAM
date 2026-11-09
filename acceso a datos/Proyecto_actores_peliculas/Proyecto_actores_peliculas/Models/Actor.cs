using Proyecto_actores_peliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_actores_peliculas
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        // Propiedad calculada: solo tiene get
        public string FullName => $"{FirstName} {LastName}";
        // Relación: un actor tiene muchas películas
        public List<Film> Films { get; set; } = new List<Film>();
    }
}
