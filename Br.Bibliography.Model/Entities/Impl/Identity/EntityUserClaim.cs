using Br.Bibliography.Model.Entities.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Identity
{
    public class EntityUserClaim : IdentityUserClaim<int>, IEntityUserClaim
    {
        #region Keys

        public int? Key { get; set; }

        [JsonIgnore]
        public override int Id { get => Key ?? Util.Constants.Base.Constant.Default.Key; set => Key = value; }

        #endregion

        #region Properties

        public override int UserId { get; set; }

        public override string? ClaimType { get; set; }

        public override string? ClaimValue { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityUser? EntityUser { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityUser? IEntityUserClaim.IEntityUser => EntityUser;

        #endregion

        #endregion
    }
}
