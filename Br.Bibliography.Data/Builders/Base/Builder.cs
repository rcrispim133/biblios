using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Base
{
    public abstract class Builder<TBuilder, TEntity> : IBuilder<TBuilder, TEntity> where TBuilder : class, IBuilder<TBuilder, TEntity>, new() where TEntity : class, IEntityBase<TEntity>
    {
        protected static int TextMaxLength = 144;

        protected static int AcronymMaxLength = 10;

        protected static int DescMaxLength = 500;

        protected static int UrlMax = 500;

        protected static int MarkMax = 5;

        protected static int RawMax = 1024 * 16;

        public abstract void Build(ModelBuilder builder);

        static IBuilder<TBuilder, TEntity>? _singleton = null;

        public static IBuilder<TBuilder, TEntity> Singleton = _singleton ?? new TBuilder();
    }
}
