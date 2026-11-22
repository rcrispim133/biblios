using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Controllers.Base.Impl
{
    public abstract class ControllerText<TEntity, TPacket> : ControllerBase<TEntity, TPacket>, IControllerText<TEntity, TPacket> where TPacket : IPacketText<TEntity> where TEntity : class, IEntityText<TEntity>
    {
    }
}
