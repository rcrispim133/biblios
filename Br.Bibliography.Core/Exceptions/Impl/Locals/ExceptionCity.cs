using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Exceptions.Impl.Locals
{
    public class ExceptionCity : ExceptionText<EntityCity>, IExceptionCity
    {
        #region Constructor

        protected ExceptionCity(EntityCity? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionCity Factory(EntityCity? entity) => new(entity);

        #endregion
    }
}
