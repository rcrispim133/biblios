using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantTitleBiblio : ConstantBase<EntityTitleBiblio>, IConstantTitleBiblio
    {
        #region Constructor

        private ConstantTitleBiblio() { }

        #endregion

        #region Factory

        public static IConstantTitleBiblio Factory() => new ConstantTitleBiblio();

        #endregion

        #region Fluent

        public override string TableName => "title_biblio";

        #endregion
    }
}
