using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Contexts.Base.Interfaces
{
    public interface IContextAcronymDesc<TEntity> : IContextAcronym<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>
    {
    }
}
