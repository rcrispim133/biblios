using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Model.Entities.Interfaces.Locals
{
    public interface IEntityCountry : IEntityText<EntityCountry>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityState>? EnumerableStates { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityState>? IEnumerableStates { get; }

        #endregion

        #endregion
    }
}
