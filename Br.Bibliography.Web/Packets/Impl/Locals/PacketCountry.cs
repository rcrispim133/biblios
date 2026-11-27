using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Locals;

namespace Br.Bibliography.Web.Packets.Impl.Locals
{
    public class PacketCountry : PacketText<EntityCountry, IPacketCountry>, IPacketCountry
    {
        private PacketCountry(int? key, EntityCountry? packet, string? message) : base(key, packet, message)
        {
        }
        private PacketCountry(EntityCountry? packet) : this(null, packet, null)
        {
        }
        public static IPacketCountry Factory(EntityCountry? packet) => new PacketCountry(packet);

        public static IEnumerable<IPacketCountry> Factory(IEnumerable<EntityCountry>? enumerable) => (enumerable ?? []).Select(x => Factory(x));
    }
}
