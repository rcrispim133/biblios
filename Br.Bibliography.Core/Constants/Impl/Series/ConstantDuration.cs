using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantDuration : ConstantText<EntityDuration>, IConstantDuration
    {
        #region Constructor

        private ConstantDuration() { }

        #endregion

        #region Factory

        public static IConstantDuration Factory() => new ConstantDuration();

        #endregion

        #region Fluent

        public override string TableName => "tbl_duration";

        #endregion

        #region Text

        public override uint ConstantMaxText => 32;

        #endregion
    }
}
