using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Data.Repositories.Exceptions.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Exceptions.Impl
{
    public class ExceptionRepositoryTextUpdate<TEntity> :
        ExceptionText<TEntity>,
        IExceptionRepositoryTextUpdate<TEntity>
            where TEntity : class, IEntityText<TEntity>, new()
    {
        #region Constructor

        private ExceptionRepositoryTextUpdate(TEntity? entity) : base(entity)
        {
        }

        #endregion

        #region Factory

        public static ExceptionRepositoryTextUpdate<TEntity> Factory(TEntity? entity) => new(entity);

        #endregion
    }
}
