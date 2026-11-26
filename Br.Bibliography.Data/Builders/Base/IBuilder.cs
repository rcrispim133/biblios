using Br.Bibliography.Core.Constants.Base;
using Br.Bibliography.Model.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Base
{
    public interface IBuilder<TBuilder, TEntity, TConstant> 
        where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new() 
        where TEntity : class, IEntity
        where TConstant : IConstant
    {
        TConstant Constant { get; init; }

        void Build(ModelBuilder builder); 
    }
}
