using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Core.Constants.Impl.Locals
{
    public class ConstantState : ConstantText<EntityState>, IConstantState
    {
        #region Constructor

        private ConstantState() { }

        #endregion

        #region Factory

        public static IConstantState Factory() => new ConstantState();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.STATE ];

        #endregion

        #region Text

        public override int ConstantMaxText => IConstantState.DefaultMaxText;

        #endregion
    }
}
