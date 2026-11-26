using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketUserClaim : PacketBase<EntityUserClaim, IPacketUserClaim>, IPacketUserClaim
    {
        private PacketUserClaim(uint? key, EntityUserClaim? packet, string? message) : base(key, packet, message)
        {
        }
        private PacketUserClaim(EntityUserClaim? packet) : this(null, packet, null)
        {
        }
        public static IPacketUserClaim Factory(EntityUserClaim? packet) => new PacketUserClaim(packet);

        public static IEnumerable<IPacketUserClaim> Factory(IEnumerable<EntityUserClaim>? enumerable) => (enumerable ?? []).Select(x => Factory(x));
    }
}
