using Br.Bibliography.Model.Entities.Base.Impl;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Interfaces.Duo;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Model.Entities.Impl.Duo
{
    public class EntityBiblioLecture : EntityBase<EntityBiblioLecture>, IEntityBiblioLecture
    {
        #region Keys

        public uint KeyBiblio { get; set; }

        public uint KeyLecture { get; set; }

        #endregion

        #region Impl

        #region Composition

        [JsonIgnore]
        public EntityBiblio? EntityBiblio { get; set; }

        [JsonIgnore]
        public EntityLecture? EntityLecture { get; set; }

        #endregion

        #endregion

        #region Scaffold

        #region Compositions

        [JsonIgnore]
        IEntityBiblio? IEntityBiblioLecture.IEntityBiblio => EntityBiblio;

        [JsonIgnore]
        IEntityLecture? IEntityBiblioLecture.IEntityLecture => EntityLecture;

        #endregion

        #endregion

    }
}
