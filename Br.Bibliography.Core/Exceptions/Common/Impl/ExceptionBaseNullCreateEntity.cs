using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Common.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Common.Impl
{
    public class ExceptionBaseNullCreateEntity<TEntity> : 
        ExceptionBase<TEntity>,
        IExceptionBaseNullCreateEntity<TEntity>
            where TEntity : class, IEntityBase<TEntity>, new()
    {
        public override TEntity? Entity { get; init; }

        protected ExceptionBaseNullCreateEntity(TEntity? entity) : base(entity)
        {
        }

        public static ExceptionBaseNullCreateEntity<TEntity> Throw() => new ExceptionBaseNullCreateEntity<TEntity>(null);

    }
}
