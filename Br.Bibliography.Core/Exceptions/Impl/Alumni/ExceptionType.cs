using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionType : ExceptionText<EntityType>, IExceptionType
    {
        public override EntityType? Entity { get; init; }

        public ExceptionType(EntityType? entity) : base(entity) { }
    }
}
