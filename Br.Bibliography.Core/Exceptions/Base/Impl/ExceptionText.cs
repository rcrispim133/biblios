using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionText<TEntity> : ExceptionBase<TEntity>, IExceptionText<TEntity> where TEntity : class, IEntityText<TEntity>, new()
    {
        #region Constructor

        protected ExceptionText(TEntity? entity) : base(entity)
        {
        }

        #endregion
    }
}
