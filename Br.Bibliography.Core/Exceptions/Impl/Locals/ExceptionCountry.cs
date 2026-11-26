using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Exceptions.Impl.Locals
{
    public class ExceptionCountry : ExceptionText<EntityCountry>, IExceptionCountry
    {
        #region Constructor

        protected ExceptionCountry(EntityCountry? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionCountry Factory(EntityCountry? entity) => new(entity);

        #endregion
    }
}
