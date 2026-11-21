using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Entitled
{
    public class EntityDisclaimer : EntityDesc<EntityDisclaimer>, IEntityDisclaimer
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityTitle>? EnumerableTitle { get; init; }
            = new HashSet<EntityTitle>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityTitle>? IEntityDisclaimer.IEnumerableTitle
            => EnumerableTitle;

        #endregion

        #endregion
    }
}
