using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public abstract class DataRepositoryBase<TEntity, TContext> : IDataRepositryBase<TEntity>
        where TEntity : class, IIdentifiableEntity
        where TContext : class, IDataContext, new()
    {
        protected abstract TEntity Create(TContext context, TEntity entity);
        protected abstract IEnumerable<TEntity> GetAll(TContext context);
        protected abstract TEntity Get(TContext context, int id);
        protected abstract TEntity Update(TContext context, TEntity entity);
        protected abstract void Delete(TContext context, TEntity entity);

        public TEntity Create(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException();

            using (TContext context = new TContext())
            {
                TEntity addedEntity = Create(context, entity);
                context.PersistChanges();
                return addedEntity;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {
                return GetAll(context);
            }
        }

        public TEntity Get(int id)
        {
            using (TContext context = new TContext())
            {
                return Get(context, id);
            }
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException();

            using (TContext context = new TContext())
            {
                TEntity existingEntity = Update(context, entity);
                context.PersistChanges();
                return entity;
            }
        }

        public void Delete(int id)
        {
            using (TContext context = new TContext())
            {
                TEntity entity = Get(context, id);
                Delete(context, entity);
                context.PersistChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException();

            using (TContext context = new TContext())
            {
                Delete(context, entity);
                context.PersistChanges();
            }
        }
    }
}

