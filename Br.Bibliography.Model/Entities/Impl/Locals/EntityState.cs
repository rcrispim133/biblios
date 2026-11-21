using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Locals
{
    public class EntityState : EntityText<EntityState>, IEntityState
    {
        #region Keys

        public uint KeyCountry { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityCountry? EntityCountry { get; set; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityCity>? EnumerableCity { get; init; }
            = new HashSet<EntityCity>();

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityCountry? IEntityState.IEntityCountry => EntityCountry;

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityCity>? IEntityState.IEnumerableCity 
            => EnumerableCity;

        #endregion

        #endregion
    }
}
