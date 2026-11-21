using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityCredit : IEntityText<EntityCredit>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityLecture>? EnumerableLecture { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityLecture>? IEnumerableLecture { get; }

        #endregion

        #endregion
    }
}
