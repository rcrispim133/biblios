using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Model.Entities.Interfaces.Locals
{
    public interface IEntityState : IEntityText<EntityState>
    {
        #region Keys

        uint KeyCountry { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityCountry? EntityCountry { get; }

        #endregion

        #region Associations

        IEnumerable<EntityCity>? EnumerableCity { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityCountry? IEntityCountry { get; }

        #endregion

        #region Associations

        IEnumerable<IEntityCity>? IEnumerableCity { get; }

        #endregion

        #endregion
    }
}
