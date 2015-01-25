using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieRental.business.entities;
using Core.Contracts;

namespace MovieRental.business.data
{
    public class MovieContext : IDataContext
    {
        public ICollection<Movie> Movies { get; set; }
        public ICollection<MovieCategory> MovieCategories { get; set; }

        public void PersistChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
