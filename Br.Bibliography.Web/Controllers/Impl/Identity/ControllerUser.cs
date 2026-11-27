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
    [Route("api/user")]
    public class ControllerUser : ControllerBase<EntityUser, IPacketUser>, IControllerUser
    {
        #region PROPERTIES

        public required override IRepositoryBase<EntityUser> Repository { get; init; }

        #endregion

        #region CONSTRUCTOR

        private ControllerUser(IRepositoryUser repository)
        {
            Repository = repository;
        }

        public ControllerUser(Context context) : this(RepositoryUser.Factory(context)) { }

        #endregion

        #region CREATE

        [HttpPost]
        public override IPacketUser? HandleCreate([FromBody] EntityUser? entity) => PacketUser.Factory(Repository.Create(entity));

        #endregion

        #region READ

        [HttpGet("{key:int}")]
        public override IPacketUser? HandleRead(int? key) => PacketUser.Factory(Repository.Read(key));

        #endregion

        #region UPDATE

        [HttpPut]
        public override IPacketUser? HandleUpdate(int? key, [FromBody] EntityUser? entity) => PacketUser.Factory(Repository.Update(key, entity));

        #endregion

        #region DELETE

        [HttpDelete("{key:int}")]
        public override IPacketUser? HandleDelete(int? key) => PacketUser.Factory(Repository.Delete(key));

        #endregion

        #region ENUMERABLE

        [HttpGet]
        public override IEnumerable<IPacketUser>? HandleEnumerable() => PacketUser.Factory(Repository.Enumerable());

        #endregion
    }
}
