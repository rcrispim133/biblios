using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Exceptions.Impl.Identity
{
    public class ExceptionRole : ExceptionBase<EntityRole>, IExceptionRole
    {
        #region Constructor

        protected ExceptionRole(EntityRole? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionRole Factory(EntityRole? entity) => new(entity);

        #endregion
    }
}
