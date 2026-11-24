using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Identity
{
    public interface IEntityUserClaim : IEntityBase<EntityUserClaim>
    {
        #region Impl

        #region Compositions

        [JsonIgnore]
        EntityUser? EntityUser { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityUser? IEntityUser { get; }

        #endregion

        #endregion
    }
}
