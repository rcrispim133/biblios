using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Repositories.Exceptions.Interfaces
{
    public interface IExceptionRepositoryTextUpdate<TEntity> : IExceptionText<TEntity> where TEntity : class, IEntityText<TEntity>, new()
    {
    }
}
