using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Constants.Impl.Entitled
{
    public class ConstantLanguage : ConstantText<EntityLanguage>, IConstantLanguage
    {
        #region Constructor

        private ConstantLanguage() { }

        #endregion

        #region Factory

        public static IConstantLanguage Factory() => new ConstantLanguage();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.LANGUAGE ];

        #endregion
    }
}
