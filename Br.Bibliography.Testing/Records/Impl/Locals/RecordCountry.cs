using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Testing.Records.Base.Impl;
using Br.Bibliography.Testing.Records.Interfaces.Locals;
using Br.Bibliography.Web.Packets.Impl.Locals;

namespace Br.Bibliography.Testing.Records.Impl.Locals
{
    public class RecordCountry : RecordText<EntityCountry, PacketCountry>, IRecordCountry
    {
        public override EntityCountry? EntityBaseDefault { get; }
    }
}
