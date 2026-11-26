using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionBase<TEntity> : IException where TEntity : class, IEntityBase<TEntity>, new()
    {
        TEntity? Entity { get; }

        delegate IExceptionBase<TEntity> DelegateEntity(TEntity? entity);
    }
}
