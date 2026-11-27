using Br.Bibliography.Model.Entities.Interfaces.Identity;
using Br.Bibliography.Util.Helpers.Base;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Identity
{
    public class EntityRole : IdentityRole<int>, IEntityRole
    {
        #region Keys

        public int? Key { get; set; }

        [JsonIgnore]
        public override int Id { get => Key ?? Helper.ZERO; set => Key = value; }

        #endregion

        #region Properties

        public override string? Name { get; set; }

        #endregion

        #region Ignore

        [JsonIgnore]
        [NotMapped]
        public override string? NormalizedName { get; set; }

        [JsonIgnore]
        [NotMapped]
        public override string? ConcurrencyStamp { get; set; }

        #endregion
    }
}
