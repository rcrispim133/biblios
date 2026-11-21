using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityTitleBiblio : EntityBase<EntityTitleBiblio>, IEntityTitleBiblio
    {
        #region Keys

        public uint KeyTitle { get; set; }

        public uint KeyBiblio { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityTitle? EntityTitle { get; set; }

        [JsonIgnore]
        public EntityBiblio? EntityBiblio { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityTitle? IEntityTitleBiblio.IEntityTitle => EntityTitle;

        [JsonIgnore]
        IEntityBiblio? IEntityTitleBiblio.IEntityBiblio => EntityBiblio;

        #endregion

        #endregion
    }
}
