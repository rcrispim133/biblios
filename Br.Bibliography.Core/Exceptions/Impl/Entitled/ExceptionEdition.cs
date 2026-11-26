using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionEdition : ExceptionText<EntityEdition>, IExceptionEdition
    {
        public override EntityEdition? Entity { get; init; }

        public ExceptionEdition(EntityEdition? entity) : base(entity) { }
    }
}
