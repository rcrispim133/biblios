using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Extensions;
using Br.Bibliography.Util.Resources;

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

        public override string[] EntityNameParts => [ StaticEntityNames.ROLE ];

        #endregion

        #region Role

        public int DefaultMaxRoleName => ResourceBase.DefaultMaxRoleName.Parse();

        #endregion
    }
}
