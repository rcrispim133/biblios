using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityLectureTeacher : IEntityBase<EntityLectureTeacher>
    {
        #region Keys

        int? KeyLecture { get; }

        int? KeyTeacher { get; }

        #endregion

        #region Imlpl

        #region Compositions

        [JsonIgnore]
        EntityLecture? EntityLecture { get; }

        [JsonIgnore]
        EntityTeacher? EntityTeacher { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityLecture? IEntityLecture { get; }

        [JsonIgnore]
        IEntityTeacher? IEntityTeacher { get; }

        #endregion

        #endregion
    }
}
