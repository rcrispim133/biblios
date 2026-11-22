using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Biblio
{
    public interface IEntityBiblio : IEntityBase<EntityBiblio>
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        IEnumerable<EntityBiblioAuthor>? EnumerableBiblioAuthor { get; init; }

        [JsonIgnore]
        IEnumerable<EntityTitleBiblio>? EnumerableTitleBiblio { get; init; }

        [JsonIgnore]
        IEnumerable<EntityBiblioImage>? EnumerableBiblioImage { get; init; }

        [JsonIgnore]
        IEnumerable<EntityBiblioLecture>? EnumerableBiblioLecture { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityBiblioAuthor>? IEnumerableBiblioAuthor { get; }

        [JsonIgnore]
        IEnumerable<IEntityTitleBiblio>? IEnumerableTitleBiblio { get; }

        [JsonIgnore]
        IEnumerable<IEntityBiblioImage>? IEnumerableBiblioImage { get; }

        [JsonIgnore]
        IEnumerable<IEntityBiblioLecture>? IEnumerableBiblioLecture { get; }

        #endregion

        #endregion

    }
}
