using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Web.Packets.Base.Interfaces
{
    public interface IPacketText<TEntity, TApi> : IPacketBase<TEntity, TApi> where TEntity : class, TApi, IEntityText<TEntity> where TApi : IEntityText<TEntity>
    {
    }
}
