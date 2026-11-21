using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Series;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityLectureCourse : IEntityBase<EntityLectureCourse>
    {
        #region Keys

        uint KeyLecture { get; }

        uint KeyCourse { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityLecture? EntityLecture { get; }

        EntityCourse? EntityCourse { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityLecture? IEntityLecture { get; }

        IEntityCourse? IEntityCourse { get; }

        #endregion

        #endregion
    }
}
