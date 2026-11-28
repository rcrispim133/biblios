using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Identity;

namespace Br.Bibliography.Web.Packets.Impl.Identity
{
    public class PacketUserRole : PacketBase<EntityUserRole, IPacketUserRole>, IPacketUserRole
    {
        private PacketUserRole(int? key, EntityUserRole? packet, string? message) : base(key, packet, message)
        {
        }
        private PacketUserRole(EntityUserRole? packet) : this(null, packet, null)
        {
        }
        public static IPacketUserRole Factory(EntityUserRole? packet) => new PacketUserRole(packet);

        public static IEnumerable<IPacketUserRole> Factory(IEnumerable<EntityUserRole>? enumerable) => (enumerable ?? []).Select(x => Factory(x));
    }
}
