using ApiPeliculasAWS.Data;
using ApiPeliculasAWS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPeliculasAWS.Repositories
{
    public class RepositoryPeliculas
    {
        private PeliculasContext context;

        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }





        public async Task<List<Pelicula>> GetPeliculasAsync()
        {
            return await this.context.Peliculas.ToListAsync();
        }


        public async Task<Pelicula> FindPeliculaAsync(int idpelicula)
        {
            return await this.context.Peliculas.FirstOrDefaultAsync(x => x.IdPelicula == idpelicula);
        }


        public async Task<List<Pelicula>> GetPeliculasByActor(string actor)
        {
            return await this.context.Peliculas
                .Where(p => p.Actores.Contains(actor))
                .ToListAsync();
        }


    }
}
