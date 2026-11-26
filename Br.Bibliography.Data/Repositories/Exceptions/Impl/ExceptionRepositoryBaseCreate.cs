using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Data.Repositories.Exceptions.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Exceptions.Impl
{
    public class ExceptionRepositoryBaseCreate<TEntity> :
        ExceptionBase<TEntity>,
        IExceptionRepositoryBaseCreate<TEntity>
            where TEntity : class, IEntityBase<TEntity>, new()
    {
        #region Constructor

        private ExceptionRepositoryBaseCreate(TEntity? entity) : base(entity)
        {
        }

        #endregion

        #region Factory

        public static ExceptionRepositoryBaseCreate<TEntity> Factory(TEntity? entity) => new(entity);

        #endregion
    }
}
