using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantBiblioLecture : ConstantBase<EntityBiblioLecture>, IConstantBiblioLecture
    {
        #region Constructor

        private ConstantBiblioLecture() { }

        #endregion

        #region Factory

        public static IConstantBiblioLecture Factory() => new ConstantBiblioLecture();

        #endregion

        #region Fluent

        public override string[] EntityNameParts => [ StaticEntityNames.BIBLIO, StaticEntityNames.LECTURE ];

        #endregion
    }
}
