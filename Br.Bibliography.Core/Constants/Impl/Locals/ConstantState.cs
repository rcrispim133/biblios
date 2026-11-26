using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Constants.Impl.Locals
{
    public class ConstantState : ConstantText<EntityState>, IConstantState
    {
        public override uint ConstantMaxText => throw new NotImplementedException();

        private ConstantState() { }

        public static IConstantState Factory() => new ConstantState();
    }
}
