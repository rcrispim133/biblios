using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionCredit : ExceptionText<EntityCredit>, IExceptionCredit
    {
        #region Constructor

        protected ExceptionCredit(EntityCredit? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionCredit Factory(EntityCredit? entity) => new(entity);

        #endregion
    }
}
