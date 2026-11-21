using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Interfaces
{
    public interface IPacketBase<TEntity> : IPacket where TEntity : class, IEntityBase<TEntity>
    {
        TEntity? Packet { get; }
    }
}
