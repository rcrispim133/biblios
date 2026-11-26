using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Base.Interfaces
{
    public interface IRepositoryBase<TEntity> : IRepository
        where TEntity : class, IEntityBase<TEntity>
    {
        #region PROPERTIES

        IContextBase<TEntity> Context { get; init; }

        #endregion

        #region CREATE

        TEntity? Create(TEntity? entity);

        #endregion

        #region READ

        TEntity? Read(uint? key);

        #endregion

        #region UPDATE

        TEntity? Update(uint? key, TEntity? entity);

        #endregion

        #region DELETE

        TEntity? Delete(uint? key);

        #endregion

        #region SINGLE

        TEntity Single(uint? key);

        #endregion

        #region ENUMERABLE

        IEnumerable<TEntity>? Enumerable();

        #endregion
    }
}
