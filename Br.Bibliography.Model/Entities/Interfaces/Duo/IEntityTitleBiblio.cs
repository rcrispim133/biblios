using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityTitleBiblio : IEntityBase<EntityTitleBiblio>
    {
        #region Keys

        uint KeyTitle { get; }

        uint KeyBiblio { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityTitle? EntityTitle { get; }

        EntityBiblio? EntityBiblio { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityTitle? IEntityTitle { get; }

        IEntityBiblio? IEntityBiblio { get; }

        #endregion

        #endregion
    }
}
