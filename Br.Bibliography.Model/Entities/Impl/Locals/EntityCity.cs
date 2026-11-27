using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Locals
{
    public class EntityCity : EntityText<EntityCity>, IEntityCity
    {
        #region Keys

        public int? KeyState { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityState? EntityState { get; set; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityPublisher>? EnumerablePublisher { get; init; }
            = new HashSet<EntityPublisher>();

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityState? IEntityCity.IEntityState => EntityState;

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityPublisher>? IEntityCity.IEnumerablePublisher
            => EnumerablePublisher;

        #endregion

        #endregion
    }
}
