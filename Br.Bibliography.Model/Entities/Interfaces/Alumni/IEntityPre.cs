using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Model.Entities.Interfaces.Alumni
{
    public interface IEntityPre : IEntityBase<EntityPre>
    {
        #region Impl

        #region Associations

        IEnumerable<EntityLecturePre>? EnumerableLecturePre { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        IEnumerable<IEntityLecturePre>? IEnumerableLecturePre { get; }

        #endregion

        #endregion
    }
}
