using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public abstract class EntityBase<TEntity> : Entity, IEntityBase<TEntity> where TEntity: class, IEntityBase<TEntity>
    {
        public uint Key { get; set; }
    }
}
