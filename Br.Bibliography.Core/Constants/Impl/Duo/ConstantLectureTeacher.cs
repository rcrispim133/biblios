using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantLectureTeacher : ConstantBase<EntityLectureTeacher>, IConstantLectureTeacher
    {
        #region Constructor

        private ConstantLectureTeacher() { }

        #endregion

        #region Factory

        public static IConstantLectureTeacher Factory() => new ConstantLectureTeacher();

        #endregion

        #region Fluent

        public override string TableName => "tbl_lecture_teacher";

        #endregion
    }
}
