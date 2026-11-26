using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantEdition : ConstantText<EntityEdition>, IConstantEdition
    {
        public override uint ConstantMaxText => throw new NotImplementedException();

        private ConstantEdition() { }

        public static IConstantEdition Factory() => new ConstantEdition();
    }
}
