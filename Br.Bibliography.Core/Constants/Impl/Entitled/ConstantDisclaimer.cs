using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantDisclaimer : ConstantDesc<EntityDisclaimer>, IConstantDisclaimer
    {
        #region Constructor

        private ConstantDisclaimer() { }

        #endregion

        #region Factory

        public static IConstantDisclaimer Factory() => new ConstantDisclaimer();

        #endregion

        #region Fluent

        public override string TableName => "tbl_disclaimer";

        #endregion

        #region Desc

        public override uint ConstantMaxDesc => 500;

        #endregion
    }
}
