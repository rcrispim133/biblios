using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Impl
{
    public abstract class PacketBase<TEntity, TApi, TPacket> : Packet, IPacketBase<TEntity, TApi> where TPacket : IPacketBase<TEntity, TApi> where TEntity : class, TApi, IEntityBase<TEntity> where TApi : IEntityBase<TEntity>
    {
        public TApi? Packet { get; set; }

        protected PacketBase(uint? key, TApi? packet, string? message)
        {
            Key = key;
            Packet = packet;
            Message = message;
        }
    }
}
