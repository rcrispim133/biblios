using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces.Locals;

namespace Br.Bibliography.Web.Packets.Impl.Locals
{
    public class PacketCountry : PacketText<EntityCountry, IPacketCountry>, IPacketCountry
    {
        private PacketCountry(uint? key, EntityCountry? packet, string? message) : base(key, packet, message) { }

        public static IPacketCountry Factory(uint? key, EntityCountry? packet, string message) => new PacketCountry(key, packet, message);

        public static IPacketCountry Factory(uint? key, EntityCountry? packet) => Factory(key, packet, string.Empty);

        public static IPacketCountry Factory(EntityCountry? packet) => Factory(packet?.Key, packet, string.Empty);

        public static IEnumerable<IPacketCountry>? Factory(IEnumerable<EntityCountry>? enumerable) => enumerable?.Select(x => Factory(x));
    }
}
