using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityLecturePre : IEntityBase<EntityLecturePre>
    {
        #region Keys

        uint KeyLecture { get; }

        uint KeyPre { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityLecture? EntityLecture { get; }

        EntityPre? EntityPre { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityLecture? IEntityLecture { get; }

        IEntityPre? IEntityPre { get; }

        #endregion

        #endregion
    }
}
