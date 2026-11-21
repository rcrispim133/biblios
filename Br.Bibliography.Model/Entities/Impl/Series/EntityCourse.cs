using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Series;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Series
{
    public class EntityCourse : EntityAcronymDesc<EntityCourse>, IEntityCourse
    {
        #region Keys

        public uint KeyUnit { get; set; }

        public uint KeyPeriod { get; set; }

        public uint KeyCycle { get; set; }

        public uint KeyDuration { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityUnit? EntityUnit { get; set; }

        [JsonIgnore]
        public EntityPeriod? EntityPeriod { get; set; }

        [JsonIgnore]
        public EntityCycle? EntityCycle { get; set; }

        [JsonIgnore]
        public EntityDuration? EntityDuration { get; set; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityLectureCourse>? EnumerableLectureCourse { get; init; }
            = new HashSet<EntityLectureCourse>();

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityUnit? IEntityCourse.IEntityUnit => EntityUnit;

        [JsonIgnore]
        IEntityPeriod? IEntityCourse.IEntityPeriod => EntityPeriod;

        [JsonIgnore]
        IEntityCycle? IEntityCourse.IEntityCycle => EntityCycle;

        [JsonIgnore]
        IEntityDuration? IEntityCourse.IEntityDuration => EntityDuration;

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLectureCourse>? IEntityCourse.IEnumerableLectureCourse
            => EnumerableLectureCourse;

        #endregion

        #endregion
    }
}
