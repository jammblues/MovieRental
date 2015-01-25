using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRental.business.entities
{
    public class MovieCategory : IIdentifiableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
