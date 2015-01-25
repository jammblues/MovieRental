using Core.Utils;
using MovieRental.business.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.business.data.DataRepositories
{
    public class MovieRepository : DataRepositoryBase<Movie>
    {
        protected override Movie Create(MovieContext context, Movie entity)
        {
            context.Movies.Add(entity);
            return entity;
        }

        protected override IEnumerable<Movie> GetAll(MovieContext context)
        {
            return context.Movies;
        }

        protected override Movie Get(MovieContext context, int id)
        {
            return context.Movies.SingleOrDefault(m => m.Id == id);
        }

        protected override Movie Update(MovieContext context, Movie entity)
        {
            var existingMovie = Get(context, entity.Id);
            SimpleMapper.PropertyMap(entity, existingMovie);
            return existingMovie;
        }

        protected override void Delete(MovieContext context, Movie entity)
        {
            context.Movies.Remove(entity);
        }
    }
}
