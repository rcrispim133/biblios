using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Impl.Identity
{
    public class ConstantUserClaim : ConstantBase<EntityUserClaim>, IConstantUserClaim
    {
        #region Constructor

        private ConstantUserClaim() { }

        #endregion

        #region Factory

        public static IConstantUserClaim Factory() => new ConstantUserClaim();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => ["user", "claim"];

        #endregion
    }
}
