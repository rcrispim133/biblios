using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantCredit : ConstantText<EntityCredit>, IConstantCredit
    {
        #region Constructor

        private ConstantCredit() { }

        #endregion

        #region Factory

        public static IConstantCredit Factory() => new ConstantCredit();

        #endregion

        #region Fluent

        public override string TableName => "tbl_credit";

        #endregion

        #region Text

        public override uint ConstantMaxText => 144;

        #endregion
    }
}
