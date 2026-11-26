using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Impl.Identity
{
    public class ConstantRole : ConstantBase<EntityRole>, IConstantRole
    {
        private ConstantRole() { }

        public static IConstantRole Factory() => new ConstantRole();
    }
}
