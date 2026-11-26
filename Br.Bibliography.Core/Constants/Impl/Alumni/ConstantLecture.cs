using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantLecture : ConstantAcronym<EntityLecture>, IConstantLecture
    {
        #region Constructor

        private ConstantLecture() { }

        #endregion

        #region Factory

        public static IConstantLecture Factory() => new ConstantLecture();

        #endregion

        #region Fluent

        public override string TableName => "tbl_lecture";

        #endregion

        #region Text

        public override uint ConstantMaxText => 144;

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => 12;

        #endregion
    }
}
