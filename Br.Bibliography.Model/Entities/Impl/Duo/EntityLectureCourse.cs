using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Series;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityLectureCourse : EntityBase<EntityLectureCourse>, IEntityLectureCourse
    {
        #region Keys

        public int? KeyLecture { get; set; }

        public int? KeyCourse { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityLecture? EntityLecture { get; set; }

        [JsonIgnore]
        public EntityCourse? EntityCourse { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityLecture? IEntityLectureCourse.IEntityLecture => EntityLecture;

        [JsonIgnore]
        IEntityCourse? IEntityLectureCourse.IEntityCourse => EntityCourse;

        #endregion

        #endregion
    }
}
