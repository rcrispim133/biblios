using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionEdition : ExceptionText<EntityEdition>, IExceptionEdition
    {
        #region Constructor

        protected ExceptionEdition(EntityEdition? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionEdition Factory(EntityEdition? entity) => new(entity);

        #endregion
    }
}
