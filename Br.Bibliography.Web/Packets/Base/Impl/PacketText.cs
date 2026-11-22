using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Impl
{
    public abstract class PacketText<TEntity, TApi, TPacket> : PacketBase<TEntity, TApi, TPacket>, IPacketText<TEntity, TApi> where TPacket : IPacketText<TEntity, TApi> where TEntity : class, TApi, IEntityText<TEntity> where TApi : IEntityText<TEntity>
    {
        protected PacketText(uint? key, TApi? packet, string? message) : base(key, packet, message) { }
    }
}
