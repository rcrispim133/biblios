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

        public override string TableName => "tbl_unit";

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => 20;

        #endregion

        #region Text

        public override uint ConstantMaxText => 72;

        #endregion
    }
}
