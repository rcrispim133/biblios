using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderText<TBuilder, TEntity, TConstant> :
        BuilderBase<TBuilder, TEntity, TConstant>,
        IBuilderText<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityText<TEntity>, new()
            where TConstant : IConstantText<TEntity>
    {
    }
}
