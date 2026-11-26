using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionTeacher : ExceptionText<EntityTeacher>, IExceptionTeacher
    {
        #region Constructor

        protected ExceptionTeacher(EntityTeacher? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionTeacher Factory(EntityTeacher? entity) => new(entity);

        #endregion
    }
}
