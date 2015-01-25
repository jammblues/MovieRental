using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.business.entities
{
    public class Movie : IIdentifiableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public List<MovieCategory> Categories { get; set; }

        #region IIdentifiableEntity

        public int EntityId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        #endregion
    }
}
