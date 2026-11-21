using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Entitled
{
    public class EntityLanguage : EntityText<EntityLanguage>, IEntityLanguage
    {
        #region Impl

        #region Association

        [JsonIgnore]
        public IEnumerable<EntityTitle>? EnumerableTitle { get; init; }
            = new HashSet<EntityTitle>();

        #endregion

        #endregion

        #region Scaffold

        #region Association

        [JsonIgnore]
        IEnumerable<IEntityTitle>? IEntityLanguage.IEnumerableTitle
            => EnumerableTitle;

        #endregion

        #endregion
    }
}
