using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityTitleUrl : IEntityBase<EntityTitleUrl>
    {
        #region Keys

        uint KeyTitle { get; }

        uint KeyUrl { get; }

        #endregion

        #region Impl

        #region Composition

        EntityTitle? EntityTitle { get; set; }

        EntityUrl? EntityUrl { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Composition

        IEntityTitle? IEntityTitle { get; }

        IEntityUrl? IEntityUrl { get; }

        #endregion

        #endregion
    }
}
