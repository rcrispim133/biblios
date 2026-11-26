using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantLecture : ConstantAcronym<EntityLecture>, IConstantLecture
    {
        public override uint ConstantMaxAcronym => throw new NotImplementedException();

        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
