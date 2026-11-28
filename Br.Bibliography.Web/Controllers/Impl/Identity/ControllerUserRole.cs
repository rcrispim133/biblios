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
    [Route("api/user/role")]
    public class ControllerUserRole : ControllerBase<EntityUserRole, IPacketUserRole>, IControllerUserRole
    {
        #region PROPERTIES

        public required override IRepositoryBase<EntityUserRole> Repository { get; init; }

        #endregion

        #region CONSTRUCTOR

        private ControllerUserRole(IRepositoryUserRole repository)
        {
            Repository = repository;
        }

        public ControllerUserRole(Context context) : this(RepositoryUserRole.Factory(context)) { }

        #endregion

        #region CREATE

        [HttpPost]
        public override IPacketUserRole? HandleCreate([FromBody] EntityUserRole? entity) => PacketUserRole.Factory(Repository.Create(entity));

        #endregion

        #region READ

        [HttpGet("{key:int}")]
        public override IPacketUserRole? HandleRead(int? key) => PacketUserRole.Factory(Repository.Read(key));

        #endregion

        #region UPDATE

        [HttpPut]
        public override IPacketUserRole? HandleUpdate(int? key, [FromBody] EntityUserRole? entity) => PacketUserRole.Factory(Repository.Update(key, entity));

        #endregion

        #region DELETE

        [HttpDelete("{key:int}")]
        public override IPacketUserRole? HandleDelete(int? key) => PacketUserRole.Factory(Repository.Delete(key));

        #endregion

        #region ENUMERABLE

        [HttpGet]
        public override IEnumerable<IPacketUserRole>? HandleEnumerable() => PacketUserRole.Factory(Repository.Enumerable());

        #endregion
    }
}
