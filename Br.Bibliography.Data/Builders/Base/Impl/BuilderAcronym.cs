using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderAcronym<TBuilder, TEntity, TConstant> :
        BuilderText<TBuilder, TEntity, TConstant>,
        IBuilderAcronym<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityAcronym<TEntity>, new()
            where TConstant : IConstantAcronym<TEntity>
    {
    }
}
