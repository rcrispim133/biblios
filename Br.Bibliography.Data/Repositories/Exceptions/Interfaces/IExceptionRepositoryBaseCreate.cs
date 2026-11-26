using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Exceptions.Interfaces
{
    public interface IExceptionRepositoryBaseCreate<TEntity> : IExceptionBase<TEntity> where TEntity : class, IEntityBase<TEntity>, new()
    {
    }
}
