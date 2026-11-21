using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public abstract class EntityAcronymDesc<TEntity> : EntityAcronym<TEntity>, IEntityAcronymDesc<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>
    {
        public string? Desc { get; set; }
    }
}
