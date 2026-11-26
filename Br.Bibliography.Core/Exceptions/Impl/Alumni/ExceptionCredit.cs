using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionCredit : ExceptionText<EntityCredit>, IExceptionCredit
    {
        public override EntityCredit? Entity { get; init; }

        public ExceptionCredit(EntityCredit? entity) : base(entity) { }
    }
}
