using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityType : IEntityText<EntityType>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityLecture>? EnumerableLecture { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLecture>? IEnumerableLecture { get; }

        #endregion

        #endregion
    }
}
