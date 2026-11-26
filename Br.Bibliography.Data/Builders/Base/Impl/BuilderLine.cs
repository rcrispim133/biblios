using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderLine<TBuilder, TEntity, TConstant> :
        BuilderText<TBuilder, TEntity, TConstant>,
        IBuilderLine<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityLine<TEntity>, new()
            where TConstant : class, IConstantLine<TEntity>, new()
    {
    }
}
