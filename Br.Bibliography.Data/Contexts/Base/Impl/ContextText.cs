using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextText<TEntity> : ContextBase<TEntity>, IContextText<TEntity> where TEntity : class, IEntityText<TEntity>
    {
        #region DbSet

        public override abstract DbSet<TEntity> DbSet { get; init; }

        #endregion

        #region Constructor
        protected ContextText(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
