using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Controllers.Base.Interfaces
{
    public interface IControllerText<TEntity, TApi, TPacket> : IControllerBase<TEntity, TApi, TPacket> where TPacket : IPacketText<TEntity, TApi> where TEntity : class, TApi, IEntityText<TEntity> where TApi : IEntityText<TEntity>
    {
    }
}
