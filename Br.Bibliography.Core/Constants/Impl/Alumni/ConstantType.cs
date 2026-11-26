using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantType : ConstantText<EntityType>, IConstantType
    {
        #region Constructor

        private ConstantType() { }

        #endregion

        #region Factory

        public static IConstantType Factory() => new ConstantType();


        #endregion

        #region Fluent

        public override string TableName => "tbl_type";

        #endregion

        #region Text

        public override uint ConstantMaxText => 32;

        #endregion
    }
}
