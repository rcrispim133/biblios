using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityUrl : IEntityText<EntityUrl>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityTitleUrl>? EnumerableTitleUrl { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Association

        [JsonIgnore]
        IEnumerable<IEntityTitleUrl>? IEnumerableTitleUrl { get; }

        #endregion

        #endregion
    }
}
