using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderAcronym<TBuilder, TEntity, TConstant> : 
        IBuilderText<TBuilder, TEntity, TConstant> 
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new() 
            where TEntity : class, IEntityAcronym<TEntity>, new()
            where TConstant : class, IConstantAcronym<TEntity>, new()
    {
    }
}
