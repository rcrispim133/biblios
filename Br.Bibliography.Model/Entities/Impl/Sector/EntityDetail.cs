using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Sector
{
    public class EntityDetail : EntityText<EntityDetail>, IEntityDetail
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntitySection>? EnumerableSection { get; init; }
            = new HashSet<EntitySection>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntitySection>? IEntityDetail.IEnumerableSection
            => EnumerableSection;

        #endregion

        #endregion
    }
}
