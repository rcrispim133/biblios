using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
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

        public override string TableName => "tbl_state";

        #endregion

        #region Text

        public override uint ConstantMaxText => IConstantState.DefaultMaxText;

        #endregion
    }
}
