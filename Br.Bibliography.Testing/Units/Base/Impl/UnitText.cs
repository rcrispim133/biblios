using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Testing.Records.Base.Interfaces;
using Br.Bibliography.Testing.Units.Base.Interfaces;
using Br.Bibliography.Web.Controllers.Base.Interfaces;
using Br.Bibliography.Web.Packets.Base.Interfaces;

namespace Br.Bibliography.Testing.Units.Base.Impl
{
    public abstract class UnitText<TEntity, TRecord, TPacket, TController> :
        UnitBase<TEntity, TRecord, TPacket, TController>,
        IUnitText<TEntity, TRecord, TPacket, TController>
        where TController : IControllerText<TEntity, TPacket>
            where TPacket : IPacketText<TEntity>
            where TRecord : IRecordText<TEntity>
            where TEntity : EntityText<TEntity>, new()
    {
        protected UnitText(TController controller, TRecord record) : base(controller, record)
        {
        }

        public void ErrorCreateEntityTextNull()
        {
            throw new NotImplementedException();
        }

        public void SuccessCreateEntityTextBlank()
        {
            throw new NotImplementedException();
        }

        public void SuccessCreateEntityTextDefault()
        {
            throw new NotImplementedException();
        }

        public void SuccessCreateEntityTextEmpty()
        {
            throw new NotImplementedException();
        }

        public void SuccessCreateEntityTextOverflow()
        {
            throw new NotImplementedException();
        }

        public void SuccessCreateEntityTextRandom()
        {
            throw new NotImplementedException();
        }
    }
}
