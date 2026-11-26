using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderText<TBuilder, TEntity, TConstant> : 
        IBuilderBase<TBuilder, TEntity, TConstant> 
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new() 
            where TEntity : class, IEntityText<TEntity>, new()
            where TConstant : class, IConstantText<TEntity>
    {
    }
}
