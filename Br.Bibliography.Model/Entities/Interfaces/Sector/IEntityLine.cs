using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Model.Entities.Interfaces.Sector
{
    public interface IEntityLine : Base.Interfaces.IEntityLine<EntityLine>
    {
        #region Keys

        uint KeySection { get; }

        #endregion

        #region Impl

        #region Compositions

        EntitySection? EntitySection { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        IEntitySection? IEntitySection { get; }

        #endregion

        #endregion
    }
}
