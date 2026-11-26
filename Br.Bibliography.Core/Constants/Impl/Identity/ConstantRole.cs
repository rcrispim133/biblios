using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Impl.Identity
{
    public class ConstantRole : ConstantBase<EntityRole>, IConstantRole
    {
        #region Constructor

        private ConstantRole() { }

        #endregion

        #region Factory

        public static IConstantRole Factory() => new ConstantRole();

        #endregion

        #region Fluent

        public override string TableName => "tbl_role";

        #endregion

    }
}
