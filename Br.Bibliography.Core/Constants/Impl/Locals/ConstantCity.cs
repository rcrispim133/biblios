using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Constants.Impl.Locals
{
    public class ConstantCity : ConstantText<EntityCity>, IConstantCity
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
