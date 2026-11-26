using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionBase<TEntity> : Exception, IExceptionBase<TEntity> where TEntity : class, IEntityBase<TEntity>, new()
    {
        public abstract TEntity? Entity { get; init; }

        protected ExceptionBase(TEntity? entity)
        {
            Entity = entity;
        }
    }
}
