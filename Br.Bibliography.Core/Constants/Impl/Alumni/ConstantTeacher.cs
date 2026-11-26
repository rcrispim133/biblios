using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantTeacher : ConstantText<EntityTeacher>, IConstantTeacher
    {
        #region Constructor

        private ConstantTeacher() { }

        #endregion

        #region Factory

        public static IConstantTeacher Factory() => new ConstantTeacher();

        #endregion

        #region Fluent

        public override string TableName => "tbl_teacher";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantTeacher.DefaultMaxText;

        #endregion
    }
}
