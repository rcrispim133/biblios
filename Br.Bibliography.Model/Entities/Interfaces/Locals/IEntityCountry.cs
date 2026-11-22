using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Locals
{
    public interface IEntityCountry : IEntityText<EntityCountry>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityState>? EnumerableStates { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityState>? IEnumerableStates { get; }

        #endregion

        #endregion
    }
}
