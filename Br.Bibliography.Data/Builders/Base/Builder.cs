using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;


namespace Br.Bibliography.Data.Builders.Base
{
    public abstract class Builder<TBuilder, TEntity> : 
        IBuilder<TBuilder, TEntity> 
            where TBuilder : class, IBuilder<TBuilder, TEntity>, new() 
            where TEntity : class, IEntityBase<TEntity>
    {
        public abstract void Build(ModelBuilder builder);

        static IBuilder<TBuilder, TEntity>? _singleton = null;

        public static IBuilder<TBuilder, TEntity> Singleton = _singleton ?? new TBuilder();

        public abstract string[] EntityNameParts { get; }
    }
}
