using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Core.Constants.Interfaces.Identity
{
    public interface IConstantUser : IConstantBase<EntityUser>
    {
        #region Defaults

        int DefaultUserNameMax { get; }

        int DefaultEmailMax { get; }

        int DefaultPasswordMax { get; }

        #endregion
    }
}
