using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionPublisher : ExceptionText<EntityPublisher>, IExceptionPublisher
    {
        #region Constructor

        protected ExceptionPublisher(EntityPublisher? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionPublisher Factory(EntityPublisher? entity) => new(entity);

        #endregion
    }
}
