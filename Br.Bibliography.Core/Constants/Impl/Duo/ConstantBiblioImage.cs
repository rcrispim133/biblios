using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantBiblioImage : ConstantBase<EntityBiblioImage>, IConstantBiblioImage
    {
        #region Constructor

        private ConstantBiblioImage() { }

        #endregion

        #region Factory

        public static IConstantBiblioImage Factory() => new ConstantBiblioImage();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.BIBLIO, StaticEntityNames.IMAGE ];

        #endregion
    }
}
