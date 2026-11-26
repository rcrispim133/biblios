using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionLine<TEntity> : IExceptionText<TEntity> where TEntity : class, IEntityLine<TEntity>, new()
    {
    }
}
