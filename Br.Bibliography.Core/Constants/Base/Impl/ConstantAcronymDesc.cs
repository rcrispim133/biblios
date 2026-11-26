using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantAcronymDesc<TEntity> : ConstantAcronym<TEntity>, IConstantAcronymDesc<TEntity>
        where TEntity : class, IEntityAcronymDesc<TEntity>, new()
    {
    }
}
