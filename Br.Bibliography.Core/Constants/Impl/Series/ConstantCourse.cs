using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantCourse : ConstantAcronymDesc<EntityCourse>, IConstantCourse
    {
        #region Constructor

        private ConstantCourse() { }

        #endregion

        #region Factory

        public static IConstantCourse Factory() => new ConstantCourse();

        #endregion

        #region Fluent

        public override string TableName => "tbl_course";

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => 32;

        #endregion

        #region Text

        public override uint ConstantMaxText => 144;

        #endregion
    }
}
