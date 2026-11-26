using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Constants.Impl.Locals
{
    public class ConstantCountry : ConstantText<EntityCountry>, IConstantCountry
    {
        #region Constructor

        private ConstantCountry() { }

        #endregion

        #region Factory

        public static IConstantCountry Factory() => new ConstantCountry();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.COUNTRY ];

        #endregion

        #region Text

        public override int PropertyTextMaxLength => IConstantCountry.DefaultTextMaxLength;

        #endregion
    }
}
