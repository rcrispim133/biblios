using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantTitle : ConstantText<EntityTitle>, IConstantTitle
    {
        #region Constructor

        private ConstantTitle() { }

        #endregion

        #region Factory

        public static IConstantTitle Factory() => new ConstantTitle();

        #endregion

        #region Fluent

        public override string TableName => "tbl_title";

        #endregion

        #region Text

        public override uint ConstantMaxText => 300;

        #endregion
    }
}
