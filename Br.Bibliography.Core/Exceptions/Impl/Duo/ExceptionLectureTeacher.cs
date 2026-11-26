using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionLectureTeacher : ExceptionBase<EntityLectureTeacher>, IExceptionLectureTeacher
    {
        #region Constructor

        protected ExceptionLectureTeacher(EntityLectureTeacher? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionLectureTeacher Factory(EntityLectureTeacher? entity) => new(entity);

        #endregion
    }
}
