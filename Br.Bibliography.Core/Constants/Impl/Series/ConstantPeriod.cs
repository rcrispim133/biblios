using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantPeriod : ConstantText<EntityPeriod>, IConstantPeriod
    {
        #region Constructor

        private ConstantPeriod() { }

        #endregion

        #region Factory

        public static IConstantPeriod Factory() => new ConstantPeriod();

        #endregion

        #region Fluent

        public override string TableName => "tbl_period";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantPeriod.DefaultMaxText;

        #endregion
    }
}
