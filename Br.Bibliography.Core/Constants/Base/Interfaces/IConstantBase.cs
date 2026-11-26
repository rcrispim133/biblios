using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantBase<TEntity> : IConstant where TEntity : class, IEntityBase<TEntity>, new()
    {
    }
}
