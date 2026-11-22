using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Interfaces
{
    public interface IPacketBase<TEntity, TApi> : IPacket where TEntity : class, TApi, IEntityBase<TEntity> where TApi : IEntityBase<TEntity>
    {
        TApi? Packet { get; }
    }
}
