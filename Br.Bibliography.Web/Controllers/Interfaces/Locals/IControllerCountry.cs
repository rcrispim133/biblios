using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Interfaces;

namespace Br.Bibliography.Web.Controllers.Interfaces.Locals
{
    public interface IControllerCountry : IControllerText<EntityCountry, IPacketCountry>
    {
    }
}
