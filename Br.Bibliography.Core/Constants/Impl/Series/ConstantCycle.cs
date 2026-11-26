using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantCycle : ConstantText<EntityCycle>, IConstantCycle
    {
        public override uint ConstantMaxText => throw new NotImplementedException();

        private ConstantCycle() { }

        public static IConstantCycle Factory() => new ConstantCycle();
    }
}
