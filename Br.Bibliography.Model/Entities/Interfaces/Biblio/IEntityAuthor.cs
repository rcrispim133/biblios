using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Biblio
{
    public interface IEntityAuthor : IEntityAcronym<EntityAuthor>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityBiblioAuthor>? EnumerableBiblioAuthor { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityBiblioAuthor>? IEnumerableBiblioAuthor { get; }

        #endregion

        #endregion
    }
}
