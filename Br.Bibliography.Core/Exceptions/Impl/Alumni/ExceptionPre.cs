using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionPre : ExceptionBase<EntityPre>, IExceptionPre
    {
        #region Constructor

        protected ExceptionPre(EntityPre? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionPre Factory(EntityPre? entity) => new(entity);

        #endregion
    }
}
