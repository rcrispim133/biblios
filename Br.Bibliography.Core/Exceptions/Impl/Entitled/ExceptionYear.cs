using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionYear : ExceptionBase<EntityYear>, IExceptionYear
    {
        #region Constructor

        protected ExceptionYear(EntityYear? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionYear Factory(EntityYear? entity) => new(entity);

        #endregion
    }
}
