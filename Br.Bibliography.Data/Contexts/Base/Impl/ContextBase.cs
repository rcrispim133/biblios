using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextBase<TEntity> : Context, IContextBase<TEntity> where TEntity : class, IEntityBase<TEntity>
    {
        #region DbSet

        public abstract DbSet<TEntity> DbSet { get; init; }

        #endregion

        #region Constructor

        public ContextBase(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }

}