using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Contexts.Base.Impl;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Impl.Identity
{
    internal class ContextRole : ContextBase<EntityRole>, IContextRole
    {
        #region Properties

        public override DbSet<EntityRole> DbSet { get; init; }

        #endregion

        #region Constructor

        public ContextRole(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
