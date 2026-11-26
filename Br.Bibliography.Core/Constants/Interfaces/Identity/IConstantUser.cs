using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Interfaces.Identity
{
    public interface IConstantUser : IConstantBase<EntityUser>
    {
        #region Defaults

        const int DefaultUserNameMax = 72;

        const int DefaultEmailMax = 72;

        const int DefaultPasswordMax = 32;

        #endregion

        #region Constants

        int UserNameMax { get; }

        int EmailMax { get; }

        int PasswordMax { get; }

        #endregion
    }
}
