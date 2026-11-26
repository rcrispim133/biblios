using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantPeriod : ConstantText<EntityPeriod>, IConstantPeriod
    {
        public override uint ConstantMaxText => throw new NotImplementedException();
    }
}
