using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Model.Entities.Interfaces.Series
{
    public interface IEntityPeriod : IEntityText<EntityPeriod>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityCourse>? EnumerableCourse { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityCourse>? IEnumerableCourse { get; }

        #endregion

        #endregion
    }
}
