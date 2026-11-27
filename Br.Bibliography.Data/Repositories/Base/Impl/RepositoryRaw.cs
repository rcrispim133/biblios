using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Exceptions.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Base.Impl
{
    public abstract class RepositoryRaw<TEntity> : RepositoryText<TEntity>, IRepositoryText<TEntity>
        where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region CONSTRUCTOR

        protected RepositoryRaw(IContextBase<TEntity> context) : base(context)
        {
        }

        #endregion

        #region CREATE

        public new TEntity? Create(TEntity? entity) => base.Create(entity);

        #endregion

        #region READ

        public new TEntity? Read(int? key) => base.Read(key);

        #endregion

        #region UPDATE

        public new TEntity? Update(int? key, TEntity? entity)
        {
            if (entity == null) throw ExceptionRepositoryRawUpdate<TEntity>.Factory(entity);
            var single = base.Single(key);
            single.Text = entity.Text;
            Context.DbSet.Update(single);
            Context.SaveChanges();
            return base.Update(key, single);
        }

        #endregion

        #region DELETE

        public new TEntity? Delete(int? key) => base.Delete(key);

        #endregion

        #region SINGLE
        
        public new TEntity Single(int? key) => base.Single(key);

        #endregion

        #region ENUMERABLE

        public new IEnumerable<TEntity>? Enumerable() => base.Enumerable();

        #endregion
    }
}
