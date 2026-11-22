using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        EntityTitle? EntityTitle { get; }

        [JsonIgnore]
        EntityBiblio? EntityBiblio { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityTitle? IEntityTitle { get; }

        [JsonIgnore]
        IEntityBiblio? IEntityBiblio { get; }

        #endregion

        #endregion
    }
}
