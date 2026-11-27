using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;


namespace Br.Bibliography.Data.Contexts.Base.Interfaces
{
    public interface IContextBase<TEntity> : IContext where TEntity : class, IEntityBase<TEntity>
    {
        #region DbSet

        DbSet<TEntity> DbSet { get; }

        #endregion
    }
}
