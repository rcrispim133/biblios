using Br.Bibliography.Core.Exceptions.Common.Impl;
using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Base.Impl
{
    public abstract class RepositoryBase<TEntity> : Repository, IRepositoryBase<TEntity> where TEntity : class, IEntityBase<TEntity>, new()
    {
        #region PROPERTIES

        public abstract IContextBase<TEntity> Context { get; init; }

        #endregion

        #region CONSTRUCTOR

        protected RepositoryBase(IContextBase<TEntity> context)
        {
            Context = context;
        }

        #endregion

        #region CREATE

        public TEntity? Create(TEntity? entity)
        {
            if (entity == null) throw ExceptionBaseNullCreateEntity<TEntity>.Throw();
            var add = Context.DbSet.Add(entity).Entity;
            Context.SaveChanges();
            return add;
        }

        #endregion

        #region READ

        public TEntity? Read(uint? key) => Context.DbSet.Find(key);

        #endregion

        #region UPDATE

        public TEntity? Update(uint? key, TEntity? entity) => Read(key); // Object has only a key. No changes. Just read.

        #endregion

        #region DELETE

        public TEntity? Delete(uint? key)
        {
            var entity = Context.DbSet.Remove(Single(key)).Entity;
            Context.SaveChanges();
            return entity;
        }

        #endregion

        #region SINGLE

        public TEntity Single(uint? key) => Context.DbSet.Single(x => x.Key == key);

        #endregion

        #region ENUMERABLE

        public IEnumerable<TEntity>? Enumerable() => Context.DbSet.AsEnumerable();

        #endregion
    }
}
