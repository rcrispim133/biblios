using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketRole : PacketBase<EntityRole, IPacketRole>, IPacketRole
    {
        private PacketRole(uint? key, EntityRole? packet, string? message) : base(key, packet, message)
        {
        }
        private PacketRole(EntityRole? packet) : this(null, packet, null)
        {
        }
        public static IPacketRole Factory(EntityRole? packet) => new PacketRole(packet);

        public static IEnumerable<IPacketRole> Factory(IEnumerable<EntityRole>? enumerable) => (enumerable ?? []).Select(x => Factory(x));
    }
}
