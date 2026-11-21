using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Alumni
{
    public class EntityPre : EntityBase<EntityPre>, IEntityPre
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityLecturePre>? EnumerableLecturePre { get; init; }
            = new HashSet<EntityLecturePre>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLecturePre>? IEntityPre.IEnumerableLecturePre
            => EnumerableLecturePre;

        #endregion

        #endregion
    }
}
