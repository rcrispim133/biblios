using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Base.Interfaces
{
    public interface IRepositoryText<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class, IEntityText<TEntity>
    {
        #region Properties

        new IContextBase<TEntity> Context { get; }

        #endregion

        #region CREATE

        new TEntity? Create(TEntity entity);

        #endregion

        #region READ

        new TEntity? Read(uint key);

        #endregion

        #region UPDATE

        new TEntity? Update(uint key, TEntity entity);

        #endregion

        #region DELETE

        new TEntity? Delete(TEntity entity);

        #endregion

        #region SINGLE

        new TEntity Single(uint key);

        #endregion

        #region ENUMERABLE

        new IEnumerable<TEntity>? Enumerable();

        #endregion
    }
}
