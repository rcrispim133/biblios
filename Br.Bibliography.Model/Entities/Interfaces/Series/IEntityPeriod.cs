using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Series;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Series
{
    public interface IEntityPeriod : IEntityText<EntityPeriod>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityCourse>? EnumerableCourse { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityCourse>? IEnumerableCourse { get; }

        #endregion

        #endregion
    }
}
