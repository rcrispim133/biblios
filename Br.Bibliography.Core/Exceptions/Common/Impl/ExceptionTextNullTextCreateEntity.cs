using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Common.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Common.Impl
{
    public class ExceptionTextNullTextCreateEntity<TEntity> :
        ExceptionBase<TEntity>,
        IExceptionBaseNullCreateEntity<TEntity>
            where TEntity : class, IEntityBase<TEntity>, new()
    {
        public override TEntity? Entity { get; init; }

        protected ExceptionTextNullTextCreateEntity(TEntity? entity) : base(entity)
        {
        }

        public static ExceptionTextNullTextCreateEntity<TEntity> Throw() => new ExceptionTextNullTextCreateEntity<TEntity>(null);

    }
}
