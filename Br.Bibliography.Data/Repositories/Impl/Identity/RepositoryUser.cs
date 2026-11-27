using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Data.Repositories.Base.Impl;
using Br.Bibliography.Data.Repositories.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Repositories.Impl.Identity
{
    public class RepositoryUser : RepositoryBase<EntityUser>, IRepositoryUser
    {
        #region Properties

        public override IContextBase<EntityUser> Context { get; init; }

        #endregion

        #region Constructor

        private RepositoryUser(IContextUser context) : base(context)
        {
            Context = context;
        }

        #endregion

        #region Factory

        public static IRepositoryUser Factory(IContextUser context) => new RepositoryUser(context);

        #endregion
    }
}
