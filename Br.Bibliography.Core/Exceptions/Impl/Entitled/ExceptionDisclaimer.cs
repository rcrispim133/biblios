using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionDisclaimer : ExceptionDesc<EntityDisclaimer>, IExceptionDisclaimer
    {
        #region Constructor

        protected ExceptionDisclaimer(EntityDisclaimer? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionDisclaimer Factory(EntityDisclaimer? entity) => new(entity);

        #endregion
    }
}
