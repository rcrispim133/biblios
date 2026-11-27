using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityPublisher : IEntityText<EntityPublisher>
    {
        #region Keys

        int? KeyCity { get; }

        #endregion

        #region Impl

        #region Composition

        [JsonIgnore]
        EntityCity? EntityCity { get; }

        #endregion

        #region Association

        [JsonIgnore]
        IEnumerable<EntityTitle>? EnumerableTitle { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Composition

        [JsonIgnore]
        IEntityCity? IEntityCity { get; }

        #endregion

        #region Association

        [JsonIgnore]
        IEnumerable<IEntityTitle>? IEnumerableTitle { get; }

        #endregion

        #endregion
    }
}
