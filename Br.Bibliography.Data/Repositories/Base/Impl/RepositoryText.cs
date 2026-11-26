using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Exceptions.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Base.Impl
{
    public abstract class RepositoryText<TEntity> : RepositoryBase<TEntity>, IRepositoryText<TEntity>
        where TEntity : class, IEntityText<TEntity>, new()
    {
        #region CONSTRUCTOR

        protected RepositoryText(IContextBase<TEntity> context) : base(context)
        {
        }

        #endregion

        #region CREATE

        public new TEntity? Create(TEntity? entity) => base.Create(entity);

        #endregion

        #region READ

        public new TEntity? Read(uint? key) => base.Read(key);

        #endregion

        #region UPDATE

        public new TEntity? Update(uint? key, TEntity? entity)
        {
            if (entity == null) throw ExceptionRepositoryTextUpdate<TEntity>.Factory(entity);
            var single = base.Single(key);
            single.Text = entity.Text;
            Context.DbSet.Update(single);
            Context.SaveChanges();
            return base.Update(key, single);
        }

        #endregion

        #region DELETE

        public new TEntity? Delete(uint? key) => base.Delete(key);

        #endregion

        #region SINGLE

        public new TEntity Single(uint? key) => base.Single(key);

        #endregion

        #region ENUMERABLE

        public new IEnumerable<TEntity>? Enumerable() => base.Enumerable();

        #endregion
    }
}
