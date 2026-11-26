using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantPre : ConstantBase<EntityPre>, IConstantPre
    {
        private ConstantPre() { }

        public static IConstantPre Factory() => new ConstantPre();
    }
}
