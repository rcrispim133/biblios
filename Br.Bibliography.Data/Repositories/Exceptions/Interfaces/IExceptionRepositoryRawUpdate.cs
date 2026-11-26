using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Exceptions.Interfaces
{
    public interface IExceptionRepositoryRawUpdate<TEntity> : IExceptionRaw<TEntity> where TEntity : class, IEntityRaw<TEntity>, new()
    {
    }
}
