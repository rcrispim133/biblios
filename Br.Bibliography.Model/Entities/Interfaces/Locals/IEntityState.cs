using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Locals
{
    public interface IEntityState : IEntityText<EntityState>
    {
        #region Keys

        uint KeyCountry { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityCountry? EntityCountry { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityCity>? EnumerableCity { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityCountry? IEntityCountry { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityCity>? IEnumerableCity { get; }

        #endregion

        #endregion
    }
}
