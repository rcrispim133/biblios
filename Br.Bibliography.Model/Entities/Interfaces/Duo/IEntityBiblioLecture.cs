using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Interfaces.Duo
{
    public interface IEntityBiblioLecture : IEntityBase<EntityBiblioLecture>
    {
        #region Keys

        uint KeyBiblio { get; }

        uint KeyLecture { get; }

        #endregion

        #region Impl

        #region Composition

        [JsonIgnore]
        EntityBiblio? EntityBiblio { get; }

        [JsonIgnore]
        EntityLecture? EntityLecture { get; }

        #endregion

        #endregion

        #region Scaffold

        #region Composition

        [JsonIgnore]
        IEntityBiblio? IEntityBiblio { get; }

        [JsonIgnore]
        IEntityLecture? IEntityLecture { get; }

        #endregion

        #endregion
    }
}
