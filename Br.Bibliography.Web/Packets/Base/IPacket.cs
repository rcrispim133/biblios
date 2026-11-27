namespace Br.Bibliography.Web.Packets.Base
{
    public interface IPacket
    {
        int? Key { get; }

        string? Message { get; }
    }
}
