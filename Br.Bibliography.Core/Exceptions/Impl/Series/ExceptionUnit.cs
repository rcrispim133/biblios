using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionUnit : ExceptionAcronym<EntityUnit>, IExceptionUnit
    {
        #region Constructor

        protected ExceptionUnit(EntityUnit? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionUnit Factory(EntityUnit? entity) => new(entity);

        #endregion
    }
}
