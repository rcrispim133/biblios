using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityTeacher : IEntityText<EntityTeacher>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityLectureTeacher>? EnumerableLectureTeacher { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLectureTeacher>? IEnumerableLectureTeacher { get; }

        #endregion

        #endregion
    }
}
