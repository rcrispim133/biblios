using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Constants.Impl.Sector
{
    public class ConstantSection : ConstantBase<EntitySection>, IConstantSection
    {
        #region Constructor

        private ConstantSection() { }

        #endregion

        #region Factory

        public static IConstantSection Factory() => new ConstantSection();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.SECTION ];

        #endregion
    }
}
