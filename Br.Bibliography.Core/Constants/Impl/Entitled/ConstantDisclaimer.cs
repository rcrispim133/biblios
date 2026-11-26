using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantDisclaimer : ConstantDesc<EntityDisclaimer>, IConstantDisclaimer
    {
        public override uint ConstantMaxDesc => throw new NotImplementedException();

        private ConstantDisclaimer() { }

        public static IConstantDisclaimer Factory() => new ConstantDisclaimer();
    }
}
