using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Alumni
{
    public class EntityTeacher : EntityText<EntityTeacher>, IEntityTeacher
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityLectureTeacher>? EnumerableLectureTeacher { get; init; }
            = new HashSet<EntityLectureTeacher>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLectureTeacher>? IEntityTeacher.IEnumerableLectureTeacher
            => EnumerableLectureTeacher;

        #endregion

        #endregion
    }
}
