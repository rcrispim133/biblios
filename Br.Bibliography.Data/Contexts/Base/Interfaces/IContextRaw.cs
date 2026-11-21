using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Contexts.Base.Interfaces
{
    public interface IContextRaw<TEntity> : IContextText<TEntity> where TEntity : class, IEntityRaw<TEntity>
    {
    }
}
