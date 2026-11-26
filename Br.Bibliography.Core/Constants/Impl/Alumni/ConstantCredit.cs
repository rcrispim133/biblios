using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantCredit : ConstantText<EntityCredit>, IConstantCredit
    {
        public override uint ConstantMaxText => throw new NotImplementedException();

        private ConstantCredit() { }

        public static IConstantCredit Factory() => new ConstantCredit();
    }
}
