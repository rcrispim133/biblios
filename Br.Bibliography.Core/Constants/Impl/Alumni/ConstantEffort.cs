using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantEffort : ConstantText<EntityEffort>, IConstantEffort
    {
        #region Constructor

        private ConstantEffort() { }

        #endregion

        #region Factory
        public static IConstantEffort Factory() => new ConstantEffort();

        #endregion

        #region Fluent

        public override string TableName => "tbl_effort";

        #endregion

        #region Text

        public override uint ConstantMaxText => 144;

        #endregion
    }
}
