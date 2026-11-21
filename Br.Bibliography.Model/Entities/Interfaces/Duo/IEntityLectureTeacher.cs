using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityLectureTeacher : IEntityBase<EntityLectureTeacher>
    {
        #region Keys

        uint KeyLecture { get; }

        uint KeyTeacher { get; }

        #endregion

        #region Imlpl

        #region Compositions

        EntityLecture? EntityLecture { get; }

        EntityTeacher? EntityTeacher { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityLecture? IEntityLecture { get; }

        IEntityTeacher? IEntityTeacher { get; }

        #endregion

        #endregion
    }
}
