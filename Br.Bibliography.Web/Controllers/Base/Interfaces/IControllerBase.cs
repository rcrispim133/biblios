using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Controllers.Base.Interfaces
{
    public interface IControllerBase<TEntity, TPacket> : IController 
        where TPacket : IPacketBase<TEntity> 
        where TEntity : class, IEntityBase<TEntity>, new()
    {
        #region PROPERTIES

        IRepositoryBase<TEntity> Repository { get; init; }

        #endregion

        #region CREATE

        TPacket? HandleCreate(TEntity? entity);

        #endregion

        #region READ

        TPacket? HandleRead(int? key);

        #endregion

        #region UPDATE

        TPacket? HandleUpdate(int? key, TEntity? entity);

        #endregion

        #region DELETE

        TPacket? HandleDelete(int? key);

        #endregion

        #region ENUMERABLE

        IEnumerable<TPacket>? HandleEnumerable();

        #endregion
    }
}
