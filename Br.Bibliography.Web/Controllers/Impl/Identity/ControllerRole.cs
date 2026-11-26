using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Repositories.Base.Interfaces;
using Br.Bibliography.Data.Repositories.Impl.Identity;
using Br.Bibliography.Data.Repositories.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Web.Controllers.Base.Impl;
using Br.Bibliography.Web.Controllers.Interfaces.Identity;
using Br.Bibliography.Web.Packets.Impl.Identity;
using Br.Bibliography.Web.Packets.Interfaces.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Br.Bibliography.Web.Controllers.Impl.Identity
{
    [ApiController]
    [Route("api/role")]
    public class ControllerRole : ControllerBase<EntityRole, IPacketRole>, IControllerRole
    {
        #region PROPERTIES

        public required override IRepositoryBase<EntityRole> Repository { get; init; }

        #endregion

        #region CONSTRUCTOR

        private ControllerRole(IRepositoryRole repository)
        {
            Repository = repository;
        }

        public ControllerRole(Context context) : this(RepositoryRole.Factory(context)) { }

        #endregion

        #region CREATE

        [HttpPost]
        public override IPacketRole? HandleCreate([FromBody] EntityRole? entity) => PacketRole.Factory(Repository.Create(entity));

        #endregion

        #region READ

        [HttpGet("{key:int:min(0)}")]
        public override IPacketRole? HandleRead(uint? key) => PacketRole.Factory(Repository.Read(key));

        #endregion

        #region UPDATE

        [HttpPut]
        public override IPacketRole? HandleUpdate(uint? key, [FromBody] EntityRole? entity) => PacketRole.Factory(Repository.Update(key, entity));

        #endregion

        #region DELETE

        [HttpDelete("{key:int:min(0)}")]
        public override IPacketRole? HandleDelete(uint? key) => PacketRole.Factory(Repository.Delete(key));

        #endregion

        #region ENUMERABLE

        [HttpGet]
        public override IEnumerable<IPacketRole>? HandleEnumerable() => PacketRole.Factory(Repository.Enumerable());

        #endregion
    }
}
