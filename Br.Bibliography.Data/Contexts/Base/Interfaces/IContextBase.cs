using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Base.Interfaces
{
    public interface IContextBase<TEntity> : IContext where TEntity : class, IEntityBase<TEntity>
    {
        #region DbSet

        DbSet<TEntity> DbSet { get; }

        #endregion
    }
}
