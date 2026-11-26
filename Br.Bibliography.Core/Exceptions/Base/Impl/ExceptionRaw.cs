using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionRaw<TEntity> :
        ExceptionText<TEntity>,
        IExceptionRaw<TEntity>
            where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region Constructor

        protected ExceptionRaw(TEntity? entity) : base(entity)
        {
        }

        #endregion
    }
}
