using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Contexts.Base.Interfaces
{
    public interface IContextDesc<TEntity> : IContextBase<TEntity> where TEntity : class, IEntityDesc<TEntity>
    {
    }
}
