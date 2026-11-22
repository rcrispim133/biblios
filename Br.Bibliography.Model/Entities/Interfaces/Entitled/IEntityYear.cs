using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityYear : IEntityBase<EntityYear>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityTitle>? EnumerableTitle { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityTitle>? IEnumerableTitle { get; }

        #endregion

        #endregion
    }
}
