using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Static;
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

        public override string[] EntityNameParts => [ StaticEntityNames.DISCLAIMER ];

        #endregion
    }
}
