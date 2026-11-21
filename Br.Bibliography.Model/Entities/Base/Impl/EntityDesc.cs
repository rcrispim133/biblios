using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public abstract class EntityDesc<TEntity> : EntityBase<TEntity>, IEntityDesc<TEntity> where TEntity : class, IEntityDesc<TEntity>
    {
        public string? Desc { get; set; }
    }
}
