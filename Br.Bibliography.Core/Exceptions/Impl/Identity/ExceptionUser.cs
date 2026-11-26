using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Exceptions.Impl.Identity
{
    public class ExceptionUser : ExceptionBase<EntityUser>, IExceptionUser
    {
        #region Constructor

        protected ExceptionUser(EntityUser? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionUser Factory(EntityUser? entity) => new(entity);

        #endregion
    }
}
