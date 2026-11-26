using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantType : ConstantText<EntityType>, IConstantType
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
