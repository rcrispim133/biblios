using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Biblio
{
    public interface IEntityAuthor : IEntityAcronym<EntityAuthor>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityBiblioAuthor>? EnumerableBiblioAuthor { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityBiblioAuthor>? IEnumerableBiblioAuthor { get; }

        #endregion

        #endregion
    }
}
