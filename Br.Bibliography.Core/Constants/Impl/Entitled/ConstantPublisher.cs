using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantPublisher : ConstantText<EntityPublisher>, IConstantPublisher
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
