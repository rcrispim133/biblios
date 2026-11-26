using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionText<TEntity> : IExceptionBase<TEntity> where TEntity : class, IEntityText<TEntity>, new()
    {
    }
}
