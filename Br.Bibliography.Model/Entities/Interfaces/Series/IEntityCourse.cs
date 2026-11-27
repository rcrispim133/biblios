using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Series
{
    public interface IEntityCourse : IEntityAcronymDesc<EntityCourse>
    {
        #region Keys

        int? KeyUnit { get; }

        int? KeyPeriod { get; }

        int? KeyCycle { get; }

        int? KeyDuration { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityUnit? EntityUnit { get; }

        [JsonIgnore]
        EntityPeriod? EntityPeriod { get; }

        [JsonIgnore]
        EntityCycle? EntityCycle { get; }

        [JsonIgnore]
        EntityDuration? EntityDuration { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityLectureCourse>? EnumerableLectureCourse { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityUnit? IEntityUnit { get; }

        [JsonIgnore]
        IEntityPeriod? IEntityPeriod { get; }

        [JsonIgnore]
        IEntityCycle? IEntityCycle { get; }

        [JsonIgnore]
        IEntityDuration? IEntityDuration { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLectureCourse>? IEnumerableLectureCourse { get; }

        #endregion

        #endregion
    }
}
