using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityBiblioImage : IEntityBase<EntityBiblioImage>
    {
        #region Keys

        uint KeyBiblio { get; }

        uint KeyImage { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityBiblio? EntityBiblio { get; }

        [JsonIgnore]
        EntityImage? EntityImage { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityBiblio? IEntityBiblio { get; }

        [JsonIgnore]
        IEntityImage? IEntityImage { get; }

        #endregion

        #endregion
    }
}
