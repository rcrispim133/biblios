using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderDesc<TBuilder, TEntity, TConstant> :
        BuilderBase<TBuilder, TEntity, TConstant>,
        IBuilderDesc<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityDesc<TEntity>, new()
            where TConstant : class, IConstantDesc<TEntity>, new()
    {
    }
}
