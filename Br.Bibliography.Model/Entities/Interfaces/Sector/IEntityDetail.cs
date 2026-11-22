using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Sector
{
    public interface IEntityDetail : IEntityText<EntityDetail>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntitySection>? EnumerableSection { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntitySection>? IEnumerableSection { get; }

        #endregion

        #endregion
    }
}
