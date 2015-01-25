using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IDataRepositryBase<T>
        where T : class, IIdentifiableEntity
    {
        //Create
        T Create(T entity);

        //Read
        IEnumerable<T> GetAll();
        T Get(int id);

        //Update
        T Update(T entity);

        //Delete
        void Delete(int id);
        void Delete(T entity);
    }
}
