using Br.Bibliography.Model.Entities.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Identity
{
    public class EntityUser : IdentityUser<uint>, IEntityUser
    {
        #region Keys

        public uint Key { get; set; }

        [JsonIgnore]
        public override uint Id { get => Key; set => Key = value; }

        #endregion

        #region Properties

        public override string? UserName { get; set; }

        public override string? Email { get; set; }

        public override bool EmailConfirmed { get; set; }

        public override string? PasswordHash { get; set; }

        #endregion

        #region Ignore

        [JsonIgnore]
        public override string? NormalizedUserName { get; set; }

        [JsonIgnore]
        public override string? NormalizedEmail { get; set; }

        [JsonIgnore]
        public override string? SecurityStamp { get; set; }

        [JsonIgnore]
        public override string? ConcurrencyStamp { get; set; }

        [JsonIgnore]
        public override string? PhoneNumber { get; set; }

        [JsonIgnore]
        public override bool PhoneNumberConfirmed { get; set; }

        [JsonIgnore]
        public override bool TwoFactorEnabled { get; set; }

        [JsonIgnore]
        public override DateTimeOffset? LockoutEnd { get; set; }

        [JsonIgnore]
        public override bool LockoutEnabled { get; set; }

        [JsonIgnore]
        public override int AccessFailedCount { get; set; }

        #endregion
    }
}
