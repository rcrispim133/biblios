using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Constants.Impl.Locals
{
    public class ConstantCity : ConstantText<EntityCity>, IConstantCity
    {
        #region Constructor

        private ConstantCity() { }

        #endregion

        #region Factory

        public static IConstantCity Factory() => new ConstantCity();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => ["city"];

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantCity.DefaultMaxText;

        #endregion
    }
}
