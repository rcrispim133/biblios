using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Sector
{
    public interface IEntitySection : IEntityBase<EntitySection>
    {
        #region Keys

        int? KeyDetail { get; }

        int? KeyLecture { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityDetail? EntityDetail { get; }

        [JsonIgnore]
        EntityLecture? EntityLecture { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityLine>? EnumerableLine { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityDetail? IEntityDetail { get; }

        [JsonIgnore]
        IEntityLecture? IEntityLecture { get; }

        #endregion

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityLine>? IEnumerableLine { get; }

        #endregion

        #endregion
    }
}
