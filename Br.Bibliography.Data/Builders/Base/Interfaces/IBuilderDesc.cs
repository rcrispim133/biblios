using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderDesc<TBuilder, TEntity> :
        IBuilderBase<TBuilder, TEntity>
            where TBuilder : class, IBuilder<TBuilder, TEntity>, new()
            where TEntity : class, IEntityDesc<TEntity>, new()
    {
    }
}
