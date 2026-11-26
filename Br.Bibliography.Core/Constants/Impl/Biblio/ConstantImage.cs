using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Constants.Impl.Biblio
{
    public class ConstantImage : ConstantRaw<EntityImage>, IConstantImage
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
