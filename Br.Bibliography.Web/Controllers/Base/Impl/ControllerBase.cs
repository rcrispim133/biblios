using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Web.Controllers.Base.Impl
{
    public abstract class ControllerBase<TEntity, TPacket> : 
        Controller, 
        IControllerBase<TEntity, TPacket> 
            where TPacket : IPacketBase<TEntity> 
            where TEntity : class, IEntityBase<TEntity>, new()
    {
        #region PROPERTIES

        public abstract IRepositoryBase<TEntity> Repository { get; init; }

        #endregion

        #region CREATE

        public abstract TPacket? HandleCreate(TEntity? entity);

        #endregion

        #region READ
  
        public abstract TPacket? HandleRead(int? key);

        #endregion

        #region UPDATE

        public abstract TPacket? HandleUpdate(int? key, TEntity? entity);

        #endregion

        #region DELETE

        public abstract TPacket? HandleDelete(int? key);

        #endregion

        #region ENUMERABLE

        public abstract IEnumerable<TPacket>? HandleEnumerable();

        #endregion
    }
}
