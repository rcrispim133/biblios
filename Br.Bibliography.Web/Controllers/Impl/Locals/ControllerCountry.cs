using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Impl.Locals;
using Br.Bibliography.Data.Repositories.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using Br.Bibliography.Web.Controllers.Base.Impl;
using Br.Bibliography.Web.Controllers.Interfaces.Locals;
using Br.Bibliography.Web.Packets.Impl;
using Br.Bibliography.Web.Packets.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Br.Bibliography.Web.Controllers.Impl.Locals
{
    [ApiController]
    [Route("api/country")]
    public class ControllerCountry : ControllerText<EntityCountry, IEntityCountry, IPacketCountry>, IControllerCountry
    {
        #region PROPERTIES

        public required override IRepositoryBase<EntityCountry> Repository { get; init; }

        #endregion

        #region CONSTRUCTOR

        private ControllerCountry(IRepositoryCountry repository)
        {
            Repository = repository;
        }

        public ControllerCountry(Context context) : this(RepositoryCountry.Factory(context)) { }

        #endregion

        #region CREATE

        [HttpPost]
        public override IPacketCountry? HandleCreate([FromBody]EntityCountry entity) => PacketCountry.Factory(Repository.Create(entity));

        #endregion

        #region READ

        [HttpGet("{key:int:min(0)}")]
        public override IPacketCountry? HandleRead(uint key) => PacketCountry.Factory(Repository.Read(key));

        #endregion

        #region UPDATE

        [HttpPut]
        public override IPacketCountry? HandleUpdate(uint key, [FromBody] EntityCountry entity) => PacketCountry.Factory(Repository.Update(key, entity));

        #endregion

        #region DELETE

        [HttpDelete]
        public override IPacketCountry? HandleDelete([FromBody] EntityCountry entity) => PacketCountry.Factory(Repository.Delete(entity));

        #endregion

        #region ENUMERABLE

        [HttpGet]
        public override IEnumerable<IPacketCountry>? HandleEnumerable() => PacketCountry.Factory(Repository.Enumerable());

        #endregion
    }
}
