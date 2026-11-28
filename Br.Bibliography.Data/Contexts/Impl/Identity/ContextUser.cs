using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Contexts.Base.Impl;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Contexts.Impl.Identity
{
    public class ContextUser : ContextBase<EntityUser>, IContextUser
    {
        #region Properties

        public override DbSet<EntityUser> DbSet { get; init; }

        #endregion

        #region Constructor

        public ContextUser(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
