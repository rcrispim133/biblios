using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantBiblioAuthor : ConstantBase<EntityBiblioAuthor>, IConstantBiblioAuthor
    {
        #region Constructor

        private ConstantBiblioAuthor() { }

        #endregion

        #region Factory

        public static IConstantBiblioAuthor Factory() => new ConstantBiblioAuthor();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR ];

        #endregion
    }
}
