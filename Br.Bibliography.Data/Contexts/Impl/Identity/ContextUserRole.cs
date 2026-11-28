using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Contexts.Base.Impl;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Impl.Identity
{
    public class ContextUserRole : ContextBase<EntityUserRole>, IContextUserRole
    {
        #region Properties

        public override DbSet<EntityUserRole> DbSet { get; init; }

        #endregion

        #region Constructor

        public ContextUserRole(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
