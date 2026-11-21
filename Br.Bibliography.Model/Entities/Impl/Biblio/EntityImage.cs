using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Biblio
{
    public class EntityImage : EntityRaw<EntityImage>, IEntityImage
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityBiblioImage>? EnumerableBiblioImage { get; init; }
            = new HashSet<EntityBiblioImage>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityBiblioImage>? IEntityImage.IEnumerableBiblioImage
            => EnumerableBiblioImage;

        #endregion

        #endregion
    }
}
