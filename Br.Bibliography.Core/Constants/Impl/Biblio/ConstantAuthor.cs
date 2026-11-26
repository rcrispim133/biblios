using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
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

        public override string TableName => "tbl_author";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantAuthor.DefaultMaxText;

        #endregion

        #region Acronym

        public override uint ConstantMaxAcronym => IConstantAuthor.DefaultMaxAcronym;

        #endregion
    }
}
