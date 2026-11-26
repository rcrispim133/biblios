using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionUrl : ExceptionText<EntityUrl>, IExceptionUrl
    {
        #region Constructor

        protected ExceptionUrl(EntityUrl? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionUrl Factory(EntityUrl? entity) => new(entity);

        #endregion
    }
}
