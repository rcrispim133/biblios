using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Identity
{
    public interface IEntityRole : IEntityBase<EntityRole>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityUserRole>? EnumerableUserRole { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityUserRole>? IEnumerableUserRole { get; }

        #endregion

        #endregion
    }
}
