using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Biblio
{
    public interface IEntityBiblio : IEntityBase<EntityBiblio>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityBiblioAuthor>? EnumerableBiblioAuthor { get; init; }

        IEnumerable<EntityTitleBiblio>? EnumerableTitleBiblio { get; init; }

        IEnumerable<EntityBiblioImage>? EnumerableBiblioImage { get; init; }

        IEnumerable<EntityBiblioLecture>? EnumerableBiblioLecture { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityBiblioAuthor>? IEnumerableBiblioAuthor { get; }

        IEnumerable<IEntityTitleBiblio>? IEnumerableTitleBiblio { get; }

        IEnumerable<IEntityBiblioImage>? IEnumerableBiblioImage { get; }

        IEnumerable<IEntityBiblioLecture>? IEnumerableBiblioLecture { get; }

        #endregion

        #endregion

    }
}
