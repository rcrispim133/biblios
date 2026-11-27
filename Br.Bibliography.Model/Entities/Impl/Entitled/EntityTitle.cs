using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Entitled
{
    public class EntityTitle : EntityText<EntityTitle>, IEntityTitle
    {
        #region Keys

        public int? KeyEdition { get; set; }

        public int? KeyPublisher { get; set; }

        public int? KeyLanguage { get; set; }

        public int? KeyYear { get; set; }

        public int? KeyDisclaimer { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityEdition? EntityEdition { get; }

        [JsonIgnore]
        public EntityPublisher? EntityPublisher { get; }

        [JsonIgnore]
        public EntityLanguage? EntityLanguage { get; }

        [JsonIgnore]
        public EntityYear? EntityYear { get; }

        [JsonIgnore]
        public EntityDisclaimer? EntityDisclaimer { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityTitleUrl>? EnumerableTitleUrl { get; init; }
            = new HashSet<EntityTitleUrl>();

        [JsonIgnore]
        public IEnumerable<EntityTitleBiblio>? EnumerableTitleBiblio { get; init; }
            = new HashSet<EntityTitleBiblio>();


        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityEdition? IEntityTitle.IEntityEdition => EntityEdition;

        [JsonIgnore]
        IEntityPublisher? IEntityTitle.IEntityPublisher => EntityPublisher;

        [JsonIgnore]
        IEntityLanguage? IEntityTitle.IEntityLanguage => EntityLanguage;

        [JsonIgnore]
        IEntityYear? IEntityTitle.IEntityYear => EntityYear;

        [JsonIgnore]
        IEntityDisclaimer? IEntityTitle.IEntityDisclaimer => EntityDisclaimer;

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityTitleUrl>? IEntityTitle.IEnumerableTitleUrl
            => EnumerableTitleUrl;

        [JsonIgnore]
        IEnumerable<IEntityTitleBiblio>? IEntityTitle.IEnumerableTitleBiblio
            => EnumerableTitleBiblio;

        #endregion

        #endregion
    }
}
