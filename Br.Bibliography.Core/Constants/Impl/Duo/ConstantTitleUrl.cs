using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantTitleUrl : ConstantBase<EntityTitleUrl>, IConstantTitleUrl
    {
        #region Constructor

        private ConstantTitleUrl() { }

        #endregion

        #region Factory

        public static IConstantTitleUrl Factory() => new ConstantTitleUrl();

        #endregion

        #region Fluent

        public override string TableName => "tbl_title_url";

        #endregion
    }
}
