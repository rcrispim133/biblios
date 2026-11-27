using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Core.Constants.Impl.Identity
{
    public class ConstantUser : ConstantBase<EntityUser>, IConstantUser
    {
        #region Constructor

        private ConstantUser() { }

        #endregion

        #region Factory

        public static IConstantUser Factory() => new ConstantUser();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.USER ];

        #endregion

        #region User

        public int DefaultUserNameMax => ResourceBase.DefaultUserNameMax.ParseFromResource();

        public int DefaultEmailMax => ResourceBase.DefaultEmailMax.ParseFromResource();

        public int DefaultPasswordMax => ResourceBase.DefaultPasswordMax.ParseFromResource();

        #endregion
    }
}
