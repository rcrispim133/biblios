using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityBiblioAuthor : IEntityBase<EntityBiblioAuthor>
    {
        #region Keys

        uint KeyBiblio { get; }

        uint KeyAuthor { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityBiblio? EntityBiblio { get; }

        [JsonIgnore]
        EntityAuthor? EntityAuthor { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityBiblio? IEntityBiblio { get; }

        [JsonIgnore]
        IEntityAuthor? IEntityAuthor { get; }

        #endregion

        #endregion
    }
}
