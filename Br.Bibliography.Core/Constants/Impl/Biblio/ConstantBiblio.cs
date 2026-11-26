using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Constants.Impl.Biblio
{
    public class ConstantBiblio : ConstantBase<EntityBiblio>, IConstantBiblio
    {
        #region Constructor

        private ConstantBiblio() { }

        #endregion

        #region Factory

        public static IConstantBiblio Factory() => new ConstantBiblio();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.BIBLIO ];

        #endregion
    }
}
