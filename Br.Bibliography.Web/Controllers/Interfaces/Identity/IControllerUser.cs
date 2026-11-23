using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Controllers.Interfaces.Identity
{
    public interface IControllerUser : IControllerBase<EntityUser, IPacketUser>
    {
    }
}
