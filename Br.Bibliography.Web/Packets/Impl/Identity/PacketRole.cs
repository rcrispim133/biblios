using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketRole : PacketBase<EntityRole, IPacketRole>, IPacketRole
    {
        private PacketRole(uint? key, EntityRole? packet, string? message) : base(key, packet, message) { }

        public static IPacketRole Factory(uint? key, EntityRole? packet, string message) => new PacketRole(key, packet, message);

        public static IPacketRole Factory(uint? key, EntityRole? packet) => Factory(key, packet, string.Empty);

        public static IPacketRole Factory(EntityRole? packet) => Factory(packet?.Key, packet, string.Empty);

        public static IEnumerable<IPacketRole>? Factory(IEnumerable<EntityRole>? enumerable) => enumerable?.Select(x => Factory(x));
    }
}
