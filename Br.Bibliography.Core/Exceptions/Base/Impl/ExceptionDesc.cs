using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionDesc<TEntity> :
        ExceptionBase<TEntity>,
        IExceptionDesc<TEntity>
            where TEntity : class, IEntityDesc<TEntity>, new()
    {
        #region Constructor

        protected ExceptionDesc(TEntity? entity) : base(entity)
        {
        }

        #endregion
    }
}
