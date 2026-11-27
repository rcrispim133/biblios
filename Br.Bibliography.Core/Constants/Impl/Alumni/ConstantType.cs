using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Constants.Impl.Alumni
{
    public class ConstantType : ConstantText<EntityType>, IConstantType
    {
        #region Constructor

        private ConstantType() { }

        #endregion

        #region Factory

        public static IConstantType Factory() => new ConstantType();


        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.TYPE ];

        #endregion
    }
}
