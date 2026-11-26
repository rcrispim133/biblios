using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Exceptions.Impl.Locals
{
    public class ExceptionState : ExceptionText<EntityState>, IExceptionState
    {
        #region Constructor

        protected ExceptionState(EntityState? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionState Factory(EntityState? entity) => new(entity);

        #endregion
    }
}
