using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Exceptions.Impl.Identity
{
    public class ExceptionUser : ExceptionBase<EntityUser>, IExceptionUser
    {
        public override EntityUser? Entity { get; init; }

        public ExceptionUser(EntityUser? entity) : base(entity) { }
    }
}
