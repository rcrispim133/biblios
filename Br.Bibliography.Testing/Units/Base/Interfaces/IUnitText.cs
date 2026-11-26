using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Testing.Records.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Units.Base.Interfaces
{
    public interface IUnitText<TEntity, TRecord, TPacket, TController> : 
        IUnitBase<TEntity, TRecord, TPacket, TController>
            where TController : IControllerBase<TEntity, TPacket>
            where TPacket : IPacketBase<TEntity>
            where TRecord : IRecordBase<TEntity>
            where TEntity : EntityBase<TEntity>, new ()
    {

        #region Success

        #region Create

        void SuccessCreateEntityTextDefault();

        void SuccessCreateEntityTextBlank();

        void SuccessCreateEntityTextEmpty();

        void SuccessCreateEntityTextOverflow();

        void SuccessCreateEntityTextRandom();

        #endregion

        #endregion

        #region Error

        #region Create

        void ErrorCreateEntityTextNull();

        #endregion

        #endregion
    }
}
