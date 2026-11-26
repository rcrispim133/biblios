using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Exceptions.Impl.Identity
{
    public class ExceptionRole : ExceptionBase<EntityRole>, IExceptionRole
    {
        public override EntityRole? Entity { get; init; }

        public ExceptionRole(EntityRole? entity) : base(entity) { }
    }
}
