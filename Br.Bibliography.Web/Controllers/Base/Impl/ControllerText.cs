using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Controllers.Base.Impl
{
    public abstract class ControllerText<TEntity, TApi, TPacket> : ControllerBase<TEntity, TApi, TPacket>, IControllerText<TEntity, TApi, TPacket> where TPacket : IPacketText<TEntity, TApi> where TEntity : class, TApi, IEntityText<TEntity> where TApi : IEntityText<TEntity>
    {
    }
}
