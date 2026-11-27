using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Static;
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

        public override string[] EntityNameParts => [ StaticEntityNames.UNIT ];

        #endregion
    }
}
