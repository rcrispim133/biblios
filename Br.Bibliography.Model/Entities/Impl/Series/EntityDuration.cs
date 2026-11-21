using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Series;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Series
{
    public class EntityDuration : EntityText<EntityDuration>, IEntityDuration
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityCourse>? EnumerableCourse { get; init; }
            = new HashSet<EntityCourse>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityCourse>? IEntityDuration.IEnumerableCourse
            => EnumerableCourse;

        #endregion

        #endregion
    }
}
