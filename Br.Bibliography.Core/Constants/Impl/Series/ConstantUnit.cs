using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantUnit : ConstantAcronym<EntityUnit>, IConstantUnit
    {
        #region Constructor

        private ConstantUnit() { }

        #endregion

        #region Factory

        public static IConstantUnit Factory() => new ConstantUnit();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => ["unit"];

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => IConstantUnit.DefaultMaxAcronym;

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantUnit.DefaultMaxText;

        #endregion
    }
}
