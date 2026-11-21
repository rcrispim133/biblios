using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Biblio
{
    public interface IEntityImage : IEntityRaw<EntityImage>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityBiblioImage>? EnumerableBiblioImage { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityBiblioImage>? IEnumerableBiblioImage { get; }

        #endregion

        #endregion
    }
}
