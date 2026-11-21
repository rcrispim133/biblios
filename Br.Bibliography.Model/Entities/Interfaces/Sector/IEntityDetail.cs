using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Model.Entities.Interfaces.Sector
{
    public interface IEntityDetail : IEntityText<EntityDetail>
    {
        #region Impl

        #region Associations

        IEnumerable<EntitySection>? EnumerableSection { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntitySection>? IEnumerableSection { get; }

        #endregion

        #endregion
    }
}
