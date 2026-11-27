using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderText<TBuilder, TEntity> :
        BuilderBase<TBuilder, TEntity>,
        IBuilderText<TBuilder, TEntity>
            where TBuilder : class, IBuilder<TBuilder, TEntity>, new()
            where TEntity : class, IEntityText<TEntity>, new()
    {
    }
}
