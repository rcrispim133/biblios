using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Controllers.Base.Interfaces
{
    public interface IControllerText<TEntity, TPacket> : IControllerBase<TEntity, TPacket> where TPacket : IPacketText<TEntity> where TEntity : class, IEntityText<TEntity>
    {
    }
}
