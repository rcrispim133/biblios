using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderAcronymDesc<TBuilder, TEntity> : BuilderAcronym<TBuilder, TEntity>, IBuilderAcronymDesc<TBuilder, TEntity> where TBuilder : class, IBuilder<TBuilder, TEntity>, new() where TEntity : class, IEntityAcronymDesc<TEntity>
    {
    }
}
