using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Biblio
{
    public class EntityAuthor : EntityAcronym<EntityAuthor>, IEntityAuthor
    {
        #region Impl

        #region Association

        [JsonIgnore]
        public IEnumerable<EntityBiblioAuthor>? EnumerableBiblioAuthor { get; init; }
            = new HashSet<EntityBiblioAuthor>();

        #endregion

        #endregion

        #region Scaffold

        #region Association

        [JsonIgnore]
        IEnumerable<IEntityBiblioAuthor>? IEntityAuthor.IEnumerableBiblioAuthor
            => EnumerableBiblioAuthor;

        #endregion

        #endregion
    }
}
