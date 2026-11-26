using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantPublisher : ConstantText<EntityPublisher>, IConstantPublisher
    {
        #region Constructor

        private ConstantPublisher() { }

        #endregion

        #region Factory

        public static IConstantPublisher Factory() => new ConstantPublisher();

        #endregion

        #region Fluent

        public override string TableName => "tbl_publisher";

        #endregion

        #region Text

        public override uint ConstantMaxText => 50;

        #endregion
    }
}
