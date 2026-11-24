using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketUserClaim : PacketBase<EntityUserClaim, IPacketUserClaim>, IPacketUserClaim
    {
        private PacketUserClaim(uint? key, EntityUserClaim? packet, string? message) : base(key, packet, message) { }

        public static IPacketUserClaim Factory(uint? key, EntityUserClaim? packet, string message) => new PacketUserClaim(key, packet, message);

        public static IPacketUserClaim Factory(uint? key, EntityUserClaim? packet) => Factory(key, packet, string.Empty);

        public static IPacketUserClaim Factory(EntityUserClaim? packet) => Factory(packet?.Key, packet, string.Empty);

        public static IEnumerable<IPacketUserClaim>? Factory(IEnumerable<EntityUserClaim>? enumerable) => enumerable?.Select(x => Factory(x));
    }
}
