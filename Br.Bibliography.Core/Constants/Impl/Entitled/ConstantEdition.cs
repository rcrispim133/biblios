using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantEdition : ConstantText<EntityEdition>, IConstantEdition
    {
        #region Cosntructor

        private ConstantEdition() { }

        #endregion

        #region Factory

        public static IConstantEdition Factory() => new ConstantEdition();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.EDITION ];

        #endregion

        #region Text

        public override int PropertyTextMaxLength => IConstantEdition.DefaultTextMaxLength;

        #endregion
    }
}
