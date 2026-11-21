using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Impl
{
    public abstract class BuilderRaw<TBuilder, TEntity> : BuilderText<TBuilder, TEntity>, IBuilderRaw<TBuilder, TEntity> where TBuilder : class, IBuilder<TBuilder, TEntity>, new() where TEntity : class, IEntityRaw<TEntity>
    {
    }
}
