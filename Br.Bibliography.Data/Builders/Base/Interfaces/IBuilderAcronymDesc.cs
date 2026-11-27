using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderAcronymDesc<TBuilder, TEntity> :
        IBuilderAcronym<TBuilder, TEntity>
            where TBuilder : class, IBuilder<TBuilder, TEntity>, new()
            where TEntity : class, IEntityAcronymDesc<TEntity>, new()
    {
    }
}
