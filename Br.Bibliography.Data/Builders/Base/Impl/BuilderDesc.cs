using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderDesc<TBuilder, TEntity> :
        BuilderBase<TBuilder, TEntity>,
        IBuilderDesc<TBuilder, TEntity>
            where TBuilder : class, IBuilder<TBuilder, TEntity>, new()
            where TEntity : class, IEntityDesc<TEntity>, new()
    {
    }
}
