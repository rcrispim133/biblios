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

        // protected static int TextMaxLength = 144;

        protected static int AcronymMaxLength = 10;

        protected static int UserNameMax = 20;

        protected static int UserRoleMax = 20;

        protected static int ClaimTypeMax = 20;

        protected static int ClaimValueMax = 20;

        protected static int PasswordMax = 1024;

        protected static int UserEmailMax = 96;

        protected static int DescMaxLength = 500;

        protected static int UrlMax = 500;

        protected static int MarkMax = 5;

        protected static int RawMax = 1024 * 16;

        public abstract void Build(ModelBuilder builder);

        static IBuilder<TBuilder, TEntity, TConstant>? _singleton = null;

        public static IBuilder<TBuilder, TEntity, TConstant> Singleton = _singleton ?? new TBuilder();
    }
}
