using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Interfaces
{
    public interface IPacketText<TEntity> : IPacketBase<TEntity> where TEntity : class, IEntityText<TEntity>
    {
    }
}
