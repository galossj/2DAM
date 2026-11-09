using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_actores_peliculas.Models;

namespace Proyecto_actores_peliculas.Repositories
{
    public interface IActorRepository
    {
        Task<Actor> GetActorAsync(int actorId);
    }
}
