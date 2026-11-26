using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionPre : ExceptionBase<EntityPre>, IExceptionPre
    {
        public override EntityPre? Entity { get; init; }

        public ExceptionPre(EntityPre? entity) : base(entity) { }
    }
}
