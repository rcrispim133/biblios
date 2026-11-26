using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Base.Interfaces;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketUser : PacketBase<EntityUser, IPacketUser>, IPacketUser
    {
        private PacketUser(uint? key, EntityUser? packet, string? message) : base(key, packet, message)
        {
        }
        private PacketUser(EntityUser? packet) : this(null, packet, null)
        {
        }
        public static IPacketUser Factory(EntityUser? packet) => new PacketUser(packet);

        public static IEnumerable<IPacketUser> Factory(IEnumerable<EntityUser>? enumerable) => (enumerable ?? []).Select(x => Factory(x));
    }
}
