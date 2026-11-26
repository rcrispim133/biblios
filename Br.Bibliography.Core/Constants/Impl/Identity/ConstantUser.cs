using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Impl.Identity
{
    public class ConstantUser : ConstantBase<EntityUser>, IConstantUser
    {
        private ConstantUser() { }

        public static IConstantUser Factory() => new ConstantUser();
    }
}
