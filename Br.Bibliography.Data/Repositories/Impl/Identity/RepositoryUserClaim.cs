using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Data.Repositories.Base.Impl;
using Br.Bibliography.Data.Repositories.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Repositories.Impl.Identity
{
    public class RepositoryUserClaim : RepositoryBase<EntityUserClaim>, IRepositoryUserClaim
    {
        #region Properties

        public override IContextBase<EntityUserClaim> Context { get; init; }

        #endregion

        #region Constructor

        private RepositoryUserClaim(IContextUserClaim context) : base(context)
        {
            Context = context;
        }

        #endregion

        #region Factory

        public static IRepositoryUserClaim Factory(IContextUserClaim context) => new RepositoryUserClaim(context);

        #endregion
    }
}
