using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Alumni
{
    public class EntityLecture : EntityAcronym<EntityLecture>, IEntityLecture
    {
        #region Keys

        public uint KeyCredit { get; set; }

        public uint KeyWork { get; set; }

        public uint KeyEffort { get; set; }

        public uint KeyType { get; set; }

        #endregion

        #region Properties

        public string? Translate { get; set; }

        public DateTime? Activation { get; set; }

        public DateTime? Deactivation { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityCredit? EntityCredit { get; set; }

        [JsonIgnore]
        public EntityWork? EntityWork { get; set; }

        [JsonIgnore]
        public EntityEffort? EntityEffort { get; set; }

        [JsonIgnore]
        public EntityType? EntityType { get; set; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntitySection>? EnumerableSection { get; init; }
            = new HashSet<EntitySection>();

        [JsonIgnore]
        public IEnumerable<EntityBiblioLecture>? EnumerableBiblioLecture { get; init; }
            = new HashSet<EntityBiblioLecture>();

        [JsonIgnore]
        public IEnumerable<EntityLecturePre>? EnumerableLecturePre { get; init; }
            = new HashSet<EntityLecturePre>();

        [JsonIgnore]
        public IEnumerable<EntityLectureCourse>? EnumerableLectureCourse { get; init; }
            = new HashSet<EntityLectureCourse>();

        [JsonIgnore]
        public IEnumerable<EntityLectureTeacher>? EnumerableLectureTeacher { get; init; }
            = new HashSet<EntityLectureTeacher>();

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityCredit? IEntityLecture.IEntityCredit => EntityCredit;

        [JsonIgnore]
        IEntityWork? IEntityLecture.IEntityWork => EntityWork;

        [JsonIgnore]
        IEntityEffort? IEntityLecture.IEntityEffort => EntityEffort;

        [JsonIgnore]
        IEntityType? IEntityLecture.IEntityType => EntityType;

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntitySection>? IEntityLecture.IEnumerableSection
            => EnumerableSection;

        [JsonIgnore]
        IEnumerable<IEntityBiblioLecture>? IEntityLecture.IEnumerableBiblioLecture
            => EnumerableBiblioLecture;

        [JsonIgnore]
        IEnumerable<IEntityLecturePre>? IEntityLecture.IEnumerableLecturePre
            => EnumerableLecturePre;

        [JsonIgnore]
        IEnumerable<IEntityLectureCourse>? IEntityLecture.IEnumerableLectureCourse
            => EnumerableLectureCourse;

        [JsonIgnore]
        IEnumerable<IEntityLectureTeacher>? IEntityLecture.IEnumerableLectureTeacher
            => EnumerableLectureTeacher;

        #endregion

        #endregion
    }
}
