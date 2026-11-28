using Br.Bibliography.Model.Entities.Interfaces.Identity;
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
        public override int Id { get => Key ?? Util.Constants.Base.Constant.Default.Key; set => Key = value; }

        #endregion

        #region Properties

        public override string? Name { get; set; }

        #endregion

        #region Impl

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityUserRole>? EnumerableUserRole { get; init; }
            = new HashSet<EntityUserRole>();

        #endregion

        #endregion

        #region Scaffold

        #region Associaitons

        IEnumerable<IEntityUserRole>? IEntityRole.IEnumerableUserRole => EnumerableUserRole;

        #endregion

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
