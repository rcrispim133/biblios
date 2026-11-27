using Br.Bibliography.Model.Entities.Base;

namespace Br.Bibliography.Model.Entities.Base.Interfaces
{
    public interface IEntityBase<TEntity> : IEntity where TEntity : class, IEntityBase<TEntity>
    {
    }
}
