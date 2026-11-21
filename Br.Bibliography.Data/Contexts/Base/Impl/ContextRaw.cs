using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

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
