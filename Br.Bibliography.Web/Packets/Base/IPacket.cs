namespace Br.Bibliography.Web.Packets.Base
{
    public interface IPacket
    {
        uint? Key { get; }

        string? Message { get; }
    }
}
