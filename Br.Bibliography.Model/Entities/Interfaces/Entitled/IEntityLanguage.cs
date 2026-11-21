using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Model.Entities.Interfaces.Entitled
{
    public interface IEntityLanguage : IEntityText<EntityLanguage>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityTitle>? EnumerableTitle { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityTitle>? IEnumerableTitle { get; }

        #endregion

        #endregion
    }
}
