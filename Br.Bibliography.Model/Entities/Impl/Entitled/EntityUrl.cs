using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Entitled
{
    public class EntityUrl : EntityText<EntityUrl>, IEntityUrl
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityTitleUrl>? EnumerableTitleUrl { get; init; }
            = new HashSet<EntityTitleUrl>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityTitleUrl>? IEntityUrl.IEnumerableTitleUrl
            => EnumerableTitleUrl;

        #endregion

        #endregion
    }
}
