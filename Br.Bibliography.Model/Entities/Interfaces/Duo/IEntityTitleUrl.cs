using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        EntityTitle? EntityTitle { get; set; }

        [JsonIgnore]
        EntityUrl? EntityUrl { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Composition

        [JsonIgnore]
        IEntityTitle? IEntityTitle { get; }

        [JsonIgnore]
        IEntityUrl? IEntityUrl { get; }

        #endregion

        #endregion
    }
}
