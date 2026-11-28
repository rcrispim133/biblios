using Br.Bibliography.Model.Entities.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;

namespace Br.Bibliography.Model.Entities.Impl.Identity
{
    public class EntityUserRole : IdentityUserRole<int>, IEntityUserRole
    {
        #region Keys

        public int? Key { get; set; }

        #endregion

        #region Impl

        #region Compositions

        public EntityUser? EntityUser { get; set; }

        public EntityRole? EntityRole { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityUser? IEntityUserRole.IEntityUser => EntityUser;

        IEntityRole? IEntityUserRole.IEntityRole => EntityRole;

        #endregion

        #endregion
    }
}
