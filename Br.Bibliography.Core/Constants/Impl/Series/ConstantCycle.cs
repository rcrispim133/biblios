using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantCycle : ConstantText<EntityCycle>, IConstantCycle
    {
        #region Constructor

        private ConstantCycle() { }

        #endregion

        #region Factory

        public static IConstantCycle Factory() => new ConstantCycle();

        #endregion

        #region Fluent

        public override string TableName => "tbl_cycle";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantCycle.DefaultMaxText;

        #endregion
    }
}
