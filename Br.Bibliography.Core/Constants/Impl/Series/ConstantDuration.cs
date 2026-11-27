using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Constants.Impl.Series
{
    public class ConstantDuration : ConstantText<EntityDuration>, IConstantDuration
    {
        #region Constructor

        private ConstantDuration() { }

        #endregion

        #region Factory

        public static IConstantDuration Factory() => new ConstantDuration();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.DURATION ];

        #endregion
    }
}
