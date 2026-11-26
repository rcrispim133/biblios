using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderBase<TBuilder, TEntity, TConstant> :
        Builder<TBuilder, TEntity, TConstant>,
        IBuilderBase<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityBase<TEntity>, new()
            where TConstant : IConstantBase<TEntity>
    {
    }
}
