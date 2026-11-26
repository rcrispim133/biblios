using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionEffort : ExceptionText<EntityEffort>, IExceptionEffort
    {
        public override EntityEffort? Entity { get; init; }

        public ExceptionEffort(EntityEffort? entity) : base(entity) { }
    }
}
