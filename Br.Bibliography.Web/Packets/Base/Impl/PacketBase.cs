using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Impl
{
    public abstract class PacketBase<TEntity, TPacket> : 
        Packet, 
        IPacketBase<TEntity> 
            where TPacket : IPacketBase<TEntity> 
            where TEntity : class, IEntityBase<TEntity>, new()
    {
        public TEntity? Packet { get; set; }

        protected PacketBase(int? key, TEntity? packet, string? message)
        {
            Key = key;
            Packet = packet;
            Message = message;
        }
    }
}
