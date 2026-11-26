using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Exceptions.Impl.Locals
{
    public class ExceptionState : ExceptionText<EntityState>, IExceptionState
    {
        public override EntityState? Entity { get; init; }

        public ExceptionState(EntityState? entity) : base(entity) { }
    }
}
