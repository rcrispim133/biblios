using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantCourse : ConstantAcronymDesc<EntityCourse>, IConstantCourse
    {
        public override uint ConstantMaxAcronym => throw new NotImplementedException();

        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
