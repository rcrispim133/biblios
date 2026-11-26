using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Exceptions.Impl.Identity
{
    public class ExceptionUserClaim : ExceptionBase<EntityUserClaim>, IExceptionUserClaim
    {
        public override EntityUserClaim? Entity { get; init; }

        public ExceptionUserClaim(EntityUserClaim? entity) : base(entity) { }
    }
}
