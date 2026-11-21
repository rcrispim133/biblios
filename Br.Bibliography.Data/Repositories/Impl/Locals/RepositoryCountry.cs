using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Contexts.Interfaces.Locals;
using Br.Bibliography.Data.Repositories.Base.Impl;
using Br.Bibliography.Data.Repositories.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Data.Repositories.Impl.Locals
{
    public class RepositoryCountry : RepositoryText<EntityCountry>, IRepositoryCountry
    {
        #region Properties

        public override IContextBase<EntityCountry> Context { get; init; }

        #endregion

        #region Constructor

        private RepositoryCountry(IContextCountry context) : base(context)
        {
            Context = context;
        }

        #endregion

        #region Factory

        public static IRepositoryCountry Factory(IContextCountry context) => new RepositoryCountry(context);

        #endregion
    }
}
