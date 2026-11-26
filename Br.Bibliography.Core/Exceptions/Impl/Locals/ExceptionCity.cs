using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Exceptions.Impl.Locals
{
    public class ExceptionCity : ExceptionText<EntityCity>, IExceptionCity
    {
        public override EntityCity? Entity { get; init; }

        public ExceptionCity(EntityCity? entity) : base(entity) { }
    }
}
