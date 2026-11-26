using Br.Bibliography.Model.Entities.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Identity
{
    public class EntityUser : IdentityUser<uint>, IEntityUser
    {
        #region Keys

        public uint? Key { get; set; }

        [JsonIgnore]
        public override uint Id { get => Key ?? 0; set => Key = value; }

        #endregion

        #region Properties

        public override string? UserName { get; set; }

        public override string? Email { get; set; }

        public override bool EmailConfirmed { get; set; }

        public override string? PasswordHash { get; set; }

        #endregion

        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityUserClaim>? EnumerableUserClaim { get; init; }
            = new HashSet<EntityUserClaim>();

        #endregion

        #endregion

        #region Scaffold

        #region Associations

        [JsonIgnore]
        IEnumerable<IEntityUserClaim>? IEntityUser.IIEnumerableLecture => EnumerableUserClaim;

        #endregion

        #endregion

        #region Ignore

        [JsonIgnore]
        [NotMapped]
        public override string? NormalizedUserName { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override string? NormalizedEmail { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override string? SecurityStamp { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override string? ConcurrencyStamp { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override string? PhoneNumber { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override bool PhoneNumberConfirmed { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override bool TwoFactorEnabled { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override DateTimeOffset? LockoutEnd { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override bool LockoutEnabled { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override int AccessFailedCount { get; set; }

        #endregion
    }
}
