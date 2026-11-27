using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Model.Entities.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Interfaces.Locals;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Entitled
{
    public class EntityPublisher : EntityText<EntityPublisher>, IEntityPublisher
    {
        #region Keys

        public int? KeyCity { get; set; }

        #endregion

        #region Impl

        #region Compositions

        [JsonIgnore]
        public EntityCity? EntityCity { get; set; }

        #endregion

        #region Associations

        [JsonIgnore]
        public IEnumerable<EntityTitle>? EnumerableTitle { get; init; }
            = new HashSet<EntityTitle>();

        #endregion

        #endregion

        #region Scaffold

        #region Composition

        [JsonIgnore]
        IEntityCity? IEntityPublisher.IEntityCity => EntityCity;

        #endregion

        #region Association

        [JsonIgnore]
        IEnumerable<IEntityTitle>? IEntityPublisher.IEnumerableTitle
            => EnumerableTitle;

        #endregion

        #endregion
    }
}
