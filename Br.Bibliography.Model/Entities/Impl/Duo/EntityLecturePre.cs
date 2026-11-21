using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityLecturePre : EntityBase<EntityLecturePre>, IEntityLecturePre
    {
        #region Keys

        public uint KeyLecture { get; set; }

        public uint KeyPre { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityLecture? EntityLecture { get; set; }

        [JsonIgnore]
        public EntityPre? EntityPre { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityLecture? IEntityLecturePre.IEntityLecture => EntityLecture;

        [JsonIgnore]
        IEntityPre? IEntityLecturePre.IEntityPre => EntityPre;

        #endregion

        #endregion
    }
}
