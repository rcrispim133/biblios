using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Constants.Impl.Duo
{
    public class ConstantBiblioLecture : ConstantBase<EntityBiblioLecture>, IConstantBiblioLecture
    {
        private ConstantBiblioLecture() { }

        public static IConstantBiblioLecture Factory() => new ConstantBiblioLecture();
    }
}
