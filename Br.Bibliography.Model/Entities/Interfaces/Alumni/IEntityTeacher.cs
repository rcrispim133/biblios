using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityTeacher : IEntityText<EntityTeacher>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityLectureTeacher>? EnumerableLectureTeacher { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityLectureTeacher>? IEnumerableLectureTeacher { get; }

        #endregion

        #endregion
    }
}
