using Br.Bibliography.Model.Entities.Impl.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Sector
{
    public interface IEntityLine : Base.Interfaces.IEntityLine<EntityLine>
    {
        #region Keys

        int? KeySection { get; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        EntitySection? EntitySection { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntitySection? IEntitySection { get; }

        #endregion

        #endregion
    }
}
