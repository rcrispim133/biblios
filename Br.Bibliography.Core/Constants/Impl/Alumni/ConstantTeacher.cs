using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Util.Static;
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

        public override string[] EntityNameParts => [ StaticEntityNames.TEACHER ];

        #endregion

        #region Text

        public override int ConstantMaxText => IConstantTeacher.DefaultMaxText;

        #endregion
    }
}
