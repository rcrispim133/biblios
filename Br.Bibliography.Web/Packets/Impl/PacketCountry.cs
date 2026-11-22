using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using Br.Bibliography.Web.Packets.Base.Impl;
using Br.Bibliography.Web.Packets.Interfaces;

namespace Br.Bibliography.Web.Packets.Impl
{
    public class PacketCountry : PacketText<EntityCountry, IEntityCountry, IPacketCountry>, IPacketCountry
    {
        private PacketCountry(uint? key, IEntityCountry? packet, string? message) : base(key, packet, message) { }

        public static IPacketCountry Factory(uint? key, IEntityCountry? packet, string message) => new PacketCountry(key, packet, message);

        public static IPacketCountry Factory(uint? key, IEntityCountry? packet) => Factory(key, packet, string.Empty);

        public static IPacketCountry Factory(IEntityCountry? packet) => Factory(packet?.Key, packet, string.Empty);

        public static IEnumerable<IPacketCountry>? Factory(IEnumerable<IEntityCountry>? enumerable) => enumerable?.Select(x => Factory(x));
    }
}
