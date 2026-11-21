using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityUrl : IEntityText<EntityUrl>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityTitleUrl>? EnumerableTitleUrl { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Association

        IEnumerable<IEntityTitleUrl>? IEnumerableTitleUrl { get; }

        #endregion

        #endregion
    }
}
