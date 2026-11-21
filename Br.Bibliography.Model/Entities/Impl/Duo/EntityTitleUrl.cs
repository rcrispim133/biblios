using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityTitleUrl : EntityBase<EntityTitleUrl>, IEntityTitleUrl
    {
        #region Keys

        public uint KeyTitle { get; set; }

        public uint KeyUrl { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityTitle? EntityTitle { get; set; }

        [JsonIgnore]
        public EntityUrl? EntityUrl { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityTitle? IEntityTitleUrl.IEntityTitle => EntityTitle;

        [JsonIgnore]
        IEntityUrl? IEntityTitleUrl.IEntityUrl => EntityUrl;

        #endregion

        #endregion
    }
}
