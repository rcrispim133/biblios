using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Biblio
{
    public class EntityBiblio : EntityBase<EntityBiblio>, IEntityBiblio
    {
        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityBiblioAuthor>? EnumerableBiblioAuthor { get; init; }
            = new HashSet<EntityBiblioAuthor>();

        [JsonIgnore]
        public IEnumerable<EntityTitleBiblio>? EnumerableTitleBiblio { get; init; }
            = new HashSet<EntityTitleBiblio>();

        [JsonIgnore]
        public IEnumerable<EntityBiblioImage>? EnumerableBiblioImage { get; init; }
            = new HashSet<EntityBiblioImage>();

        [JsonIgnore]
        public IEnumerable<EntityBiblioLecture>? EnumerableBiblioLecture { get; init; }
            = new HashSet<EntityBiblioLecture>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityBiblioAuthor>? IEntityBiblio.IEnumerableBiblioAuthor
            => EnumerableBiblioAuthor;

        [JsonIgnore]
        IEnumerable<IEntityTitleBiblio>? IEntityBiblio.IEnumerableTitleBiblio
            => EnumerableTitleBiblio;

        [JsonIgnore]
        IEnumerable<IEntityBiblioImage>? IEntityBiblio.IEnumerableBiblioImage
            => EnumerableBiblioImage;

        [JsonIgnore]
        IEnumerable<IEntityBiblioLecture>? IEntityBiblio.IEnumerableBiblioLecture
            => EnumerableBiblioLecture;

        #endregion

        #endregion
    }
}
