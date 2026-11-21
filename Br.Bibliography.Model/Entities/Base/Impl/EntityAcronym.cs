using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public abstract class EntityAcronym<TEntity> : EntityText<TEntity>, IEntityAcronym<TEntity> where TEntity : class, IEntityAcronym<TEntity>
    {
        public string? Acronym { get; set; }
    }
}
