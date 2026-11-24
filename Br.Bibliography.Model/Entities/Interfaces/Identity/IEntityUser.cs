using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Identity
{
    public interface IEntityUser : IEntityBase<EntityUser>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityUserClaim>? EnumerableUserClaim { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityUserClaim>? IIEnumerableLecture { get; }

        #endregion

        #endregion
    }
}
