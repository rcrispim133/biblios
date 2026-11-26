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

        public override string[] EntityNameParts => ["lecture"];

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantLecture.DefaultMaxText;

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => IConstantLecture.DefaultMaxAcronym;

        #endregion
    }
}
