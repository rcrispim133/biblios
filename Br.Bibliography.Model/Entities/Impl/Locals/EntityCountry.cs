using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Locals
{
    public class EntityCountry : EntityText<EntityCountry>, IEntityCountry
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityState>? EnumerableStates { get; init; }
            = new HashSet<EntityState>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityState>? IEntityCountry.IEnumerableStates
            => EnumerableStates;

        #endregion

        #endregion
    }
}
