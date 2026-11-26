using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionAcronymDesc<TEntity> :
        ExceptionAcronym<TEntity>,
        IExceptionAcronymDesc<TEntity>
            where TEntity : class, IEntityAcronymDesc<TEntity>, new()
    {
        #region Constructor

        protected ExceptionAcronymDesc(TEntity? entity) : base(entity)
        {
        }

        #endregion
    }
}
