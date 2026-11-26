using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Constants.Impl.Sector
{
    public class ConstantLine : ConstantLine<EntityLine>, Interfaces.Sector.IConstantLine
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
