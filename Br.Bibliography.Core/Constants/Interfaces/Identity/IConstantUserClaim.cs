using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Interfaces.Identity
{
    public interface IConstantUserClaim : IConstantBase<EntityUserClaim>
    {
        #region Defaults

        const int DefaultMaxUserClaim = 72;

        #endregion

        #region Constants

        int MaxUserClaim { get; }

        #endregion
    }
}
