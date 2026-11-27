using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;


namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextRaw<TEntity> : ContextText<TEntity>, IContextRaw<TEntity> where TEntity : class, IEntityRaw<TEntity>
    {
        #region DbSet

        public override abstract DbSet<TEntity> DbSet { get; init; }

        #endregion

        #region Constructor

        protected ContextRaw(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
