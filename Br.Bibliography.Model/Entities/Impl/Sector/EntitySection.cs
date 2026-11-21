using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Sector
{
    public class EntitySection : EntityBase<EntitySection>, IEntitySection
    {
        #region Keys

        public uint KeyDetail { get; set; }

        public uint KeyLecture { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityDetail? EntityDetail { get; set; }

        [JsonIgnore]
        public EntityLecture? EntityLecture { get; set; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityLine>? EnumerableLine { get; init; }
            = new HashSet<EntityLine>();

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityDetail? IEntitySection.IEntityDetail => EntityDetail;

        [JsonIgnore]
        IEntityLecture? IEntitySection.IEntityLecture => EntityLecture;

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLine>? IEntitySection.IEnumerableLine
            => EnumerableLine;

        #endregion

        #endregion
    }
}
