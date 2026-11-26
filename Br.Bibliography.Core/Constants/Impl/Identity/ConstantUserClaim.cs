using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Impl.Identity
{
    public class ConstantUserClaim : ConstantBase<EntityUserClaim>, IConstantUserClaim
    {
        private ConstantUserClaim() { }

        public static IConstantUserClaim Factory() => new ConstantUserClaim();
    }
}
