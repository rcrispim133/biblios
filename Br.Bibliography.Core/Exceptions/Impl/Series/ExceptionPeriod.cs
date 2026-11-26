using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionPeriod : ExceptionText<EntityPeriod>, IExceptionPeriod
    {
        #region Constructor

        protected ExceptionPeriod(EntityPeriod? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionPeriod Factory(EntityPeriod? entity) => new(entity);

        #endregion
    }
}
