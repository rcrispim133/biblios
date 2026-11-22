using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Impl
{
    public abstract class PacketText<TEntity, TPacket> : PacketBase<TEntity, TPacket>, IPacketText<TEntity> where TPacket : IPacketText<TEntity> where TEntity : class, IEntityText<TEntity>
    {
        protected PacketText(uint? key, TEntity? packet, string? message) : base(key, packet, message) { }
    }
}
