using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityBiblioImage : EntityBase<EntityBiblioImage>, IEntityBiblioImage
    {
        #region Keys

        public int? KeyBiblio { get; set; }

        public int? KeyImage { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityBiblio? EntityBiblio { get; set; }

        [JsonIgnore]
        public EntityImage? EntityImage { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityBiblio? IEntityBiblioImage.IEntityBiblio => EntityBiblio;

        [JsonIgnore]
        IEntityImage? IEntityBiblioImage.IEntityImage => EntityImage;

        #endregion

        #endregion
    }
}
