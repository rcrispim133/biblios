using Br.Bibliography.Core.Constants.Base;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Base
{
    public abstract class Builder<TBuilder, TEntity, TConstant> : 
        IBuilder<TBuilder, TEntity, TConstant> 
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new() 
            where TEntity : class, IEntityBase<TEntity>
            where TConstant : IConstant
    {
        public abstract TConstant Constant { get; init; }

        public abstract void Build(ModelBuilder builder);

        static IBuilder<TBuilder, TEntity, TConstant>? _singleton = null;

        public static IBuilder<TBuilder, TEntity, TConstant> Singleton = _singleton ?? new TBuilder();
    }
}
