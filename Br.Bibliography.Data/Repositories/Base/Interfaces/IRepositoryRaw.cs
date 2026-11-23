using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Base.Interfaces
{
    public interface IRepositoryRaw<TEntity> : IRepositoryText<TEntity>
        where TEntity : class, IEntityRaw<TEntity>
    {
        #region PROPERTIES

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

        new TEntity? Delete(uint key);

        #endregion

        #region SINGLE

        new TEntity Single(uint entity);

        #endregion

        #region ENUMERABLE

        new IEnumerable<TEntity>? Enumerable();

        #endregion
    }
}
