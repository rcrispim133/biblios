using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionTitleBiblio : ExceptionBase<EntityTitleBiblio>, IExceptionTitleBiblio
    {
        #region Constructor

        protected ExceptionTitleBiblio(EntityTitleBiblio? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionTitleBiblio Factory(EntityTitleBiblio? entity) => new(entity);

        #endregion
    }
}
