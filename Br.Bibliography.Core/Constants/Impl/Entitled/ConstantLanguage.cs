using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantLanguage : ConstantText<EntityLanguage>, IConstantLanguage
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
