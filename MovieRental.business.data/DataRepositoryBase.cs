using Core.Contracts;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.business.data
{
    public abstract class DataRepositoryBase<TEntity> : DataRepositoryBase<TEntity, MovieContext>
        where TEntity : class, IIdentifiableEntity
    {
    }
}
