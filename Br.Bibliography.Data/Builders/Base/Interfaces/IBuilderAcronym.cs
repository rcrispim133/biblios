using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderAcronym<TBuilder, TEntity> : 
        IBuilderText<TBuilder, TEntity> 
            where TBuilder : class, IBuilder<TBuilder, TEntity>, new() 
            where TEntity : class, IEntityAcronym<TEntity>, new()
    {
    }
}
