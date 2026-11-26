using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionEffort : ExceptionText<EntityEffort>, IExceptionEffort
    {
        #region Constructor

        protected ExceptionEffort(EntityEffort? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionEffort Factory(EntityEffort? entity) => new(entity);

        #endregion
    }
}
