using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityLecture : IEntityAcronym<EntityLecture>
    {
        #region Keys

        int? KeyCredit { get; }

        int? KeyWork { get; }

        int? KeyEffort { get; }

        int? KeyType { get; }

        #endregion

        #region Properties

        string? Translate { get; }

        DateTime? Activation { get; }

        DateTime? Deactivation { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityCredit? EntityCredit { get; }

        [JsonIgnore]
        EntityWork? EntityWork { get; }

        [JsonIgnore]
        EntityEffort? EntityEffort { get; }

        [JsonIgnore]
        EntityType? EntityType { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<EntitySection>? EnumerableSection { get; init; }

        [JsonIgnore]
        IEnumerable<EntityBiblioLecture>? EnumerableBiblioLecture { get; init; }

        [JsonIgnore]
        IEnumerable<EntityLecturePre>? EnumerableLecturePre { get; init; }

        [JsonIgnore]
        IEnumerable<EntityLectureCourse>? EnumerableLectureCourse { get; init; }

        [JsonIgnore]
        IEnumerable<EntityLectureTeacher>? EnumerableLectureTeacher { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityCredit? IEntityCredit { get; }

        [JsonIgnore]
        IEntityWork? IEntityWork { get; }

        [JsonIgnore]
        IEntityEffort? IEntityEffort { get; }

        [JsonIgnore]
        IEntityType? IEntityType { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntitySection>? IEnumerableSection { get; }

        [JsonIgnore]
        IEnumerable<IEntityBiblioLecture>? IEnumerableBiblioLecture { get; }

        [JsonIgnore]
        IEnumerable<IEntityLecturePre>? IEnumerableLecturePre { get; }

        [JsonIgnore]
        IEnumerable<IEntityLectureCourse>? IEnumerableLectureCourse { get; }

        [JsonIgnore]
        IEnumerable<IEntityLectureTeacher>? IEnumerableLectureTeacher { get; }

        #endregion

        #endregion
    }
}
