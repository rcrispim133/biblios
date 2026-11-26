using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Exceptions.Impl.Locals
{
    public class ExceptionCountry : ExceptionText<EntityCountry>, IExceptionCountry
    {
        public override EntityCountry? Entity { get; init; }

        public ExceptionCountry(EntityCountry? entity) : base(entity) { }
    }
}
