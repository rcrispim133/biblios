using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantUrl : ConstantText<EntityUrl>, IConstantUrl
    {
        #region Constructor

        private ConstantUrl() { }

        #endregion

        #region Factory

        public static IConstantUrl Factory() => new ConstantUrl();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.URL ];

        #endregion
    }
}
