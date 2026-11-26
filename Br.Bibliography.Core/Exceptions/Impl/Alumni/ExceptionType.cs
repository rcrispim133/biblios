using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionType : ExceptionText<EntityType>, IExceptionType
    {
        #region Constructor

        protected ExceptionType(EntityType? entity): base(entity) { }

        #endregion

        #region Factory

        public static ExceptionType Factory(EntityType? entity) => new(entity);

        #endregion
    }
}
