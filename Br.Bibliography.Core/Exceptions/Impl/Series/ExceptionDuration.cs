using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionDuration : ExceptionText<EntityDuration>, IExceptionDuration
    {
        #region Constructor

        protected ExceptionDuration(EntityDuration? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionDuration Factory(EntityDuration? entity) => new(entity);

        #endregion
    }
}
