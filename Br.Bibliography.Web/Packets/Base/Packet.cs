namespace Br.Bibliography.Web.Packets.Base
{
    public abstract class Packet : IPacket
    {
        public uint? Key { get; set; }

        public string? Message { get; set; }
    }
}
