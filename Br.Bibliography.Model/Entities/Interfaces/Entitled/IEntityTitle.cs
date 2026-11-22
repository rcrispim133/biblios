using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityTitle : IEntityText<EntityTitle>
    {
        #region Keys

        uint KeyEdition { get; }

        uint KeyPublisher { get; }

        uint KeyLanguage { get; }

        uint KeyYear { get; }

        uint KeyDisclaimer { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityEdition? EntityEdition { get; }

        [JsonIgnore]
        EntityPublisher? EntityPublisher { get; }

        [JsonIgnore]
        EntityLanguage? EntityLanguage { get; }

        [JsonIgnore]
        EntityYear? EntityYear { get; }

        [JsonIgnore]
        EntityDisclaimer? EntityDisclaimer { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityTitleUrl>? EnumerableTitleUrl { get; init; }

        [JsonIgnore]
        IEnumerable<EntityTitleBiblio>? EnumerableTitleBiblio { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityEdition? IEntityEdition { get; }

        [JsonIgnore]
        IEntityPublisher? IEntityPublisher { get; }

        [JsonIgnore]
        IEntityLanguage? IEntityLanguage { get; }

        [JsonIgnore]
        IEntityYear? IEntityYear { get; }

        [JsonIgnore]
        IEntityDisclaimer? IEntityDisclaimer { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityTitleUrl>? IEnumerableTitleUrl { get; }

        [JsonIgnore]
        IEnumerable<IEntityTitleBiblio>? IEnumerableTitleBiblio { get; }

        #endregion

        #endregion
    }
}
