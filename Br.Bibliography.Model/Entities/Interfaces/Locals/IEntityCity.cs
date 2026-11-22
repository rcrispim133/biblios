using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Locals
{
    public interface IEntityCity : IEntityText<EntityCity>
    {
        #region Keys

        uint KeyState { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityState? EntityState { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityPublisher>? EnumerablePublisher { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Composition

        IEntityState? IEntityState { get; }

        #endregion

        #region Associations

        IEnumerable<IEntityPublisher>? IEnumerablePublisher { get; }

        #endregion

        #endregion
    }
}
