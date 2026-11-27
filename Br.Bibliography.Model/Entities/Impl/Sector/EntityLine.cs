using Br.Bibliography.Model.Entities.Interfaces.Sector;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Sector
{
    public class EntityLine : Base.Impl.EntityLine<EntityLine>, IEntityLine
    {
        #region Keys

        public int? KeySection { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntitySection? EntitySection { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntitySection? IEntityLine.IEntitySection
            => EntitySection;

        #endregion

        #endregion
    }
}
