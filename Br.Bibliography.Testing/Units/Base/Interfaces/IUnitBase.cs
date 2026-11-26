using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Testing.Records.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Units.Base.Interfaces
{
    public interface IUnitBase<TEntity, TRecord, TPacket, TController> : IUnit 
        where TController : IControllerBase<TEntity, TPacket> 
        where TPacket : IPacketBase<TEntity> 
        where TRecord : IRecordBase<TEntity>
        where TEntity : EntityBase<TEntity>, new()
    {
        #region Properties

        TController Controller { get; init; }

        #endregion

        #region Success

        #region Create

        void SuccessCreateEntityBaseDefault();

        void SuccessCreateEntityBaseZeroKey();

        void SuccessCreateEntityBaseMinKey();

        void SuccessCreateEntityBaseMaxKey();

        void SuccessCreateEntityBaseRandomKey();

        #endregion

        #endregion

        #region Error

        #region Create

        void ErrorCreateEntityBaseNull();

        #endregion

        #endregion
    }
}
