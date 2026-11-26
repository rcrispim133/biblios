using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantLectureCourse : ConstantBase<EntityLectureCourse>, IConstantLectureCourse
    {
        #region Constructor

        private ConstantLectureCourse() { }

        #endregion

        #region Factory

        public static IConstantLectureCourse Factory() => new ConstantLectureCourse();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.LECTURE, StaticEntityNames.COURSE ];

        #endregion
    }
}
