using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Series
{
    public interface IEntityCourse : IEntityAcronymDesc<EntityCourse>
    {
        #region Keys

        uint KeyUnit { get; }

        uint KeyPeriod { get; }

        uint KeyCycle { get; }

        uint KeyDuration { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityUnit? EntityUnit { get; }

        EntityPeriod? EntityPeriod { get; }

        EntityCycle? EntityCycle { get; }

        EntityDuration? EntityDuration { get; }

        #endregion

        #region Associations

        IEnumerable<EntityLectureCourse>? EnumerableLectureCourse { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityUnit? IEntityUnit { get; }

        IEntityPeriod? IEntityPeriod { get; }

        IEntityCycle? IEntityCycle { get; }

        IEntityDuration? IEntityDuration { get; }

        #endregion

        #region Associations

        IEnumerable<IEntityLectureCourse>? IEnumerableLectureCourse { get; }

        #endregion

        #endregion
    }
}
