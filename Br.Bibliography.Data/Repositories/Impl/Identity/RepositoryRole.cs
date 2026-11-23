using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Data.Repositories.Base.Impl;
using Br.Bibliography.Data.Repositories.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Repositories.Impl.Identity
{
    public class RepositoryRole : RepositoryBase<EntityRole>, IRepositoryRole
    {
        #region Properties

        public override IContextBase<EntityRole> Context { get; init; }

        #endregion

        #region Constructor

        private RepositoryRole(IContextRole context) : base(context)
        {
            Context = context;
        }

        #endregion

        #region Factory

        public static IRepositoryRole Factory(IContextRole context) => new RepositoryRole(context);

        #endregion
    }
}
