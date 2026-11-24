using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Contexts.Base.Impl;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Impl.Identity
{
    public class ContextUserClaim : ContextBase<EntityUserClaim>, IContextUserClaim
    {
        #region Properties

        public override DbSet<EntityUserClaim> DbSet { get; init; }

        #endregion

        #region Constructor

        public ContextUserClaim(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
