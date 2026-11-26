using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Data.Repositories.Exceptions.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Exceptions.Impl
{
    public class ExceptionRepositoryRawUpdate<TEntity> :
        ExceptionRaw<TEntity>,
        IExceptionRepositoryRawUpdate<TEntity>
            where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region Constructor

        private ExceptionRepositoryRawUpdate(TEntity? entity) : base(entity)
        {
        }

        #endregion

        #region Factory

        public static ExceptionRepositoryRawUpdate<TEntity> Factory(TEntity? entity) => new(entity);

        #endregion
    }
}
