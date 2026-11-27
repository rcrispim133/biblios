using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

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

        public override string[] EntityNameParts => [ StaticEntityNames.USER, StaticEntityNames.CLAIM ];

        #endregion

        #region User Claim

        public int DefaultMaxUserClaim => ResourceBase.DefaultMaxUserClaim.ParseFromResource();

        #endregion
    }
}
