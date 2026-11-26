using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Interfaces.Identity
{
    public interface IConstantRole : IConstantBase<EntityRole>
    {
        #region Defaults

        const int DefaultMaxRoleName = 96;

        #endregion

        #region Constants

        int MaxRoleName { get; }

        #endregion
    }
}
