using Br.Bibliography.Model.Entities.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Identity
{
    public class EntityUserClaim : IdentityUserClaim<uint>, IEntityUserClaim
    {
        #region Keys

        public uint Key { get; set; }

        [JsonIgnore]
        public override int Id { get => (int)Key; set => Key = (uint)value; }

        #endregion

        #region Properties

        public override uint UserId { get; set; }

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
