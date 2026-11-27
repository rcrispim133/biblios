using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Constants.Impl.Biblio
{
    public class ConstantAuthor : ConstantAcronym<EntityAuthor>, IConstantAuthor
    {
        #region Constructor

        private ConstantAuthor() { }

        #endregion

        #region Factory

        public static IConstantAuthor Factory() => new ConstantAuthor();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.AUTHOR ];

        #endregion
    }
}
