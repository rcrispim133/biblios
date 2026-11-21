using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Interfaces.Series;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Series
{
    public class EntityPeriod : EntityText<EntityPeriod>, IEntityPeriod
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
        IEnumerable<IEntityCourse>? IEntityPeriod.IEnumerableCourse
            => EnumerableCourse;

        #endregion

        #endregion
    }
}
