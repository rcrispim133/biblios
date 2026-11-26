using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Exceptions.Impl.Identity
{
    public class ExceptionUserClaim : ExceptionBase<EntityUserClaim>, IExceptionUserClaim
    {
        #region Constructor

        protected ExceptionUserClaim(EntityUserClaim? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionUserClaim Factory(EntityUserClaim? entity) => new(entity);

        #endregion
    }
}
