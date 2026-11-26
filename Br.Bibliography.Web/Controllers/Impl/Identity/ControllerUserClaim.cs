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
    [Route("api/user/claim")]
    public class ControllerUserClaim : ControllerBase<EntityUserClaim, IPacketUserClaim>, IControllerUserClaim
    {
        #region PROPERTIES

        public required override IRepositoryBase<EntityUserClaim> Repository { get; init; }

        #endregion

        #region CONSTRUCTOR

        private ControllerUserClaim(IRepositoryUserClaim repository)
        {
            Repository = repository;
        }

        public ControllerUserClaim(Context context) : this(RepositoryUserClaim.Factory(context)) { }

        #endregion

        #region CREATE

        [HttpPost]
        public override IPacketUserClaim? HandleCreate([FromBody] EntityUserClaim? entity) => PacketUserClaim.Factory(Repository.Create(entity));

        #endregion

        #region READ

        [HttpGet("{key:int:min(0)}")]
        public override IPacketUserClaim? HandleRead(uint? key) => PacketUserClaim.Factory(Repository.Read(key));

        #endregion

        #region UPDATE

        [HttpPut]
        public override IPacketUserClaim? HandleUpdate(uint? key, [FromBody] EntityUserClaim? entity) => PacketUserClaim.Factory(Repository.Update(key, entity));

        #endregion

        #region DELETE

        [HttpDelete("{key:int:min(0)}")]
        public override IPacketUserClaim? HandleDelete(uint? key) => PacketUserClaim.Factory(Repository.Delete(key));

        #endregion

        #region ENUMERABLE

        [HttpGet]
        public override IEnumerable<IPacketUserClaim>? HandleEnumerable() => PacketUserClaim.Factory(Repository.Enumerable());

        #endregion
    }
}
