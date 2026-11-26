using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Util.Static;
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

        public override string[] EntityNameParts => [ StaticEntityNames.LECTURE ];

        #endregion

        #region Text

        public override int PropertyTextMaxLength => IConstantLecture.DefaultTextMaxLength;

        #endregion

        #region Acronym

        public override int PropertyAcronymMaxLength => IConstantLecture.DefaultMaxAcronym;

        #endregion
    }
}
