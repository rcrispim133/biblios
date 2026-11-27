using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Interfaces.Identity
{
    public interface IConstantUserClaim : IConstantBase<EntityUserClaim>
    {
        #region Defaults

        int DefaultMaxUserClaim { get; }

        #endregion
    }
}
