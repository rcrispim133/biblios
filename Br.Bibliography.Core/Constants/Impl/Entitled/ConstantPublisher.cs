using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Util.Static;
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

        public override string[] EntityNameParts => [ StaticEntityNames.PUBLISHER ];

        #endregion

        #region Text

        public override int PropertyTextMaxLength => IConstantPublisher.DefaultTextMaxLength;

        #endregion
    }
}
