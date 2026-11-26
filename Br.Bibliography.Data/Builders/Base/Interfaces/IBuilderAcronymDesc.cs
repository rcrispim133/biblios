using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderAcronymDesc<TBuilder, TEntity, TConstant> :
        IBuilderAcronym<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityAcronymDesc<TEntity>, new()
            where TConstant : class, IConstantAcronymDesc<TEntity>, new()
    {
    }
}
