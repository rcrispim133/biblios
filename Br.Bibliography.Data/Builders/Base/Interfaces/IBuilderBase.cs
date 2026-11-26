using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderBase<TBuilder, TEntity, TConstant> : 
        IBuilder<TBuilder, TEntity, TConstant> 
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new() 
            where TEntity : class, IEntityBase<TEntity>, new()
            where TConstant : class, IConstantBase<TEntity>
    {
    }
}
