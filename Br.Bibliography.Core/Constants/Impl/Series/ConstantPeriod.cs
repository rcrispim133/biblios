using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantPeriod : ConstantText<EntityPeriod>, IConstantPeriod
    {
        #region Constructor

        private ConstantPeriod() { }

        #endregion

        #region Factory

        public static IConstantPeriod Factory() => new ConstantPeriod();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.PERIOD ];

        #endregion
    }
}
