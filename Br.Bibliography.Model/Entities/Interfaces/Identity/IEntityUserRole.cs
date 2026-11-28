using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Model.Entities.Interfaces.Identity
{
    public interface IEntityUserRole : IEntityBase<EntityUserRole>
    {
        #region Impl

        #region Compositions

        EntityUser? EntityUser { get; set; }

        EntityRole? EntityRole { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityUser? IEntityUser { get; }

        IEntityRole? IEntityRole { get; }

        #endregion

        #endregion
    }
}
