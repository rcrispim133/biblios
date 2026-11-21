using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Sector;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityLecture : IEntityAcronym<EntityLecture>
    {
        #region Keys

        uint KeyCredit { get; }

        uint KeyWork { get; }

        uint KeyEffort { get; }

        uint KeyType { get; }

        #endregion

        #region Properties

        string? Translate { get; }

        DateTime? Activation { get; }

        DateTime? Deactivation { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityCredit? EntityCredit { get; }

        EntityWork? EntityWork { get; }

        EntityEffort? EntityEffort { get; }

        EntityType? EntityType { get; }

        #endregion

        #region Associations

        IEnumerable<EntitySection>? EnumerableSection { get; init; }

        IEnumerable<EntityBiblioLecture>? EnumerableBiblioLecture { get; init; }

        IEnumerable<EntityLecturePre>? EnumerableLecturePre { get; init; }

        IEnumerable<EntityLectureCourse>? EnumerableLectureCourse { get; init; }

        IEnumerable<EntityLectureTeacher>? EnumerableLectureTeacher { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityCredit? IEntityCredit { get; }

        IEntityWork? IEntityWork { get; }

        IEntityEffort? IEntityEffort { get; }

        IEntityType? IEntityType { get; }

        #endregion

        #region Associations

        IEnumerable<IEntitySection>? IEnumerableSection { get; }

        IEnumerable<IEntityBiblioLecture>? IEnumerableBiblioLecture { get; }

        IEnumerable<IEntityLecturePre>? IEnumerableLecturePre { get; }

        IEnumerable<IEntityLectureCourse>? IEnumerableLectureCourse { get; }

        IEnumerable<IEntityLectureTeacher>? IEnumerableLectureTeacher { get; }

        #endregion

        #endregion
    }
}
