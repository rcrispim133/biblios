using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityLectureTeacher : EntityBase<EntityLectureTeacher>, IEntityLectureTeacher
    {
        #region Keys

        public int? KeyLecture { get; set; }

        public int? KeyTeacher { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityLecture? EntityLecture { get; set; }

        [JsonIgnore]
        public EntityTeacher? EntityTeacher { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityLecture? IEntityLectureTeacher.IEntityLecture => EntityLecture;

        [JsonIgnore]
        IEntityTeacher? IEntityLectureTeacher.IEntityTeacher => EntityTeacher;

        #endregion

        #endregion
    }
}
