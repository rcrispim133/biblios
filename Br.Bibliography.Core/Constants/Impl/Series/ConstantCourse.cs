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

        public override string[] EntityNameParts => ["course"];

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => IConstantCourse.DefaultMaxAcronym;

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantCourse.DefaultMaxText;

        #endregion
    }
}
