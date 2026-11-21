using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;

namespace Br.Bibliography.Model.Entities.Interfaces.Sector
{
    public interface IEntitySection : IEntityBase<EntitySection>
    {
        #region Keys

        uint KeyDetail { get; }

        uint KeyLecture { get; }

        #endregion

        #region Impl

        #region Compositions

        EntityDetail? EntityDetail { get; }

        EntityLecture? EntityLecture { get; }

        #endregion

        #region Associations

        IEnumerable<EntityLine>? EnumerableLine { get; init; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntityDetail? IEntityDetail { get; }

        IEntityLecture? IEntityLecture { get; }

        #endregion

        #region Associations

        IEnumerable<IEntityLine>? IEnumerableLine { get; }

        #endregion

        #endregion
    }
}
