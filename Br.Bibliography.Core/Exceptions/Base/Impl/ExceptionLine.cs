using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionLine<TEntity> :
        ExceptionText<TEntity>,
        IExceptionLine<TEntity>
            where TEntity : class, IEntityLine<TEntity>, new()
    {
        #region Constructor

        protected ExceptionLine(TEntity? entity) : base(entity)
        {
        }

        #endregion
    }
}
