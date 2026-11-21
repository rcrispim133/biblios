using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Contexts.Base.Interfaces
{
    public interface IContextText<TEntity> : IContextBase<TEntity> where TEntity : class, IEntityText<TEntity>
    {
    }
}
