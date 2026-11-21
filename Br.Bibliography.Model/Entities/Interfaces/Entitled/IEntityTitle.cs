using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityTitle : IEntityText<EntityTitle>
    {
        #region Keys

        uint KeyEdition { get; }

        uint KeyPublisher { get; }

        uint KeyLanguage { get; }

        uint KeyYear { get; }

        uint KeyDisclaimer { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityEdition? EntityEdition { get; }

        EntityPublisher? EntityPublisher { get; }

        EntityLanguage? EntityLanguage { get; }

        EntityYear? EntityYear { get; }

        EntityDisclaimer? EntityDisclaimer { get; }

        #endregion

        #region Associations

        IEnumerable<EntityTitleUrl>? EnumerableTitleUrl { get; init; }

        IEnumerable<EntityTitleBiblio>? EnumerableTitleBiblio { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityEdition? IEntityEdition { get; }

        IEntityPublisher? IEntityPublisher { get; }

        IEntityLanguage? IEntityLanguage { get; }

        IEntityYear? IEntityYear { get; }

        IEntityDisclaimer? IEntityDisclaimer { get; }

        #endregion

        #region Associations

        IEnumerable<IEntityTitleUrl>? IEnumerableTitleUrl { get; }

        IEnumerable<IEntityTitleBiblio>? IEnumerableTitleBiblio { get; }

        #endregion

        #endregion
    }
}
