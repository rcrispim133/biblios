using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketUser : PacketBase<EntityUser, IPacketUser>, IPacketUser
    {
        private PacketUser(uint? key, EntityUser? packet, string? message) : base(key, packet, message) { }

        public static IPacketUser Factory(uint? key, EntityUser? packet, string message) => new PacketUser(key, packet, message);

        public static IPacketUser Factory(uint? key, EntityUser? packet) => Factory(key, packet, string.Empty);

        public static IPacketUser Factory(EntityUser? packet) => Factory(packet?.Key, packet, string.Empty);

        public static IEnumerable<IPacketUser>? Factory(IEnumerable<EntityUser>? enumerable) => enumerable?.Select(x => Factory(x));
    }
}
