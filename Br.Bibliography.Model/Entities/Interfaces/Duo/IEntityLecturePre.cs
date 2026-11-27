using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityLecturePre : IEntityBase<EntityLecturePre>
    {
        #region Keys

        int? KeyLecture { get; }

        int? KeyPre { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityLecture? EntityLecture { get; }

        [JsonIgnore]
        EntityPre? EntityPre { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityLecture? IEntityLecture { get; }

        [JsonIgnore]
        IEntityPre? IEntityPre { get; }

        #endregion

        #endregion
    }
}
