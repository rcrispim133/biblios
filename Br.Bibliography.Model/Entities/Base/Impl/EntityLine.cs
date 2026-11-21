using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Model.Entities.Base.Impl
{
    public abstract class EntityLine<TEntity> : EntityText<TEntity>, IEntityLine<TEntity> where TEntity : class, IEntityLine<TEntity>
    {
        public string? LineMark { get; set; }

        public uint? LineOrder { get; set; }
    }
}
