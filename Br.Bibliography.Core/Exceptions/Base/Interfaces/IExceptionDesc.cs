using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionDesc<TEntity> : IExceptionBase<TEntity> where TEntity : class, IEntityDesc<TEntity>, new()
    {
    }
}
