using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionRaw<TEntity> : IExceptionText<TEntity> where TEntity : class, IEntityRaw<TEntity>, new()
    {
    }
}
