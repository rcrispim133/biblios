using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionTitleUrl : ExceptionBase<EntityTitleUrl>, IExceptionTitleUrl
    {
        #region Constructor

        protected ExceptionTitleUrl(EntityTitleUrl? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionTitleUrl Factory(EntityTitleUrl? entity) => new(entity);

        #endregion
    }
}