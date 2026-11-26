using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantBase<TEntity> : Constant, IConstantBase<TEntity> where TEntity : class, IEntityBase<TEntity>, new()
    {
    }
}
