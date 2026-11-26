using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Constants.Impl.Sector
{
    public class ConstantDetail : ConstantText<EntityDetail>, IConstantDetail
    {
        #region Constructor

        private ConstantDetail() { }

        #endregion

        #region Factory

        public static IConstantDetail Factory() => new ConstantDetail();

        #endregion

        #region Fluent

        public override string TableName => "tbl_detail";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantDetail.DefaultMaxText;

        #endregion
    }
}
