using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public abstract class EntityText<TEntity> : EntityBase<TEntity>, IEntityText<TEntity> where TEntity : class, IEntityText<TEntity>
    {
        public string? Text { get; set; }
    }
}
