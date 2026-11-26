using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderAcronymDesc<TBuilder, TEntity, TConstant> :
        BuilderAcronym<TBuilder, TEntity, TConstant>,
        IBuilderAcronymDesc<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityAcronymDesc<TEntity>, new()
            where TConstant : IConstantAcronymDesc<TEntity>
    {
    }
}
