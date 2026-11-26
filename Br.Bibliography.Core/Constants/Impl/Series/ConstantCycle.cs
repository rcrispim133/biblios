using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantCycle : ConstantText<EntityCycle>, IConstantCycle
    {
        #region Constructor

        private ConstantCycle() { }

        #endregion

        #region Factory

        public static IConstantCycle Factory() => new ConstantCycle();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.CYCLE ];

        #endregion

        #region Text

        public override int PropertyTextMaxLength => IConstantCycle.DefaultTextMaxLength;

        #endregion
    }
}
