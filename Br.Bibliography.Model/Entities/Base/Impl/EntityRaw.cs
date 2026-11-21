using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public class EntityRaw<TEntity> : EntityText<TEntity>, IEntityRaw<TEntity> where TEntity : class, IEntityRaw<TEntity>
    {
        public byte[]? Raw { get; set; }
    }
}
