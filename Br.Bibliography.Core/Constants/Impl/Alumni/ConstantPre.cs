using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantPre : ConstantBase<EntityPre>, IConstantPre
    {
        #region Constructor

        private ConstantPre() { }

        #endregion

        #region Factory

        public static IConstantPre Factory() => new ConstantPre();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.PRE ];

        #endregion
    }
}
