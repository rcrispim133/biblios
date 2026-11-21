using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Alumni
{
    public class EntityType : EntityText<EntityType>, IEntityType
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityLecture>? EnumerableLecture { get; init; }
            = new HashSet<EntityLecture>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLecture>? IEntityType.IEnumerableLecture
            => EnumerableLecture;

        #endregion

        #endregion
    }
}
