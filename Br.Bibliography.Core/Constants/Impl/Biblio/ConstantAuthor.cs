using Br.Bibliography.Core.Constants.Base.Impl;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Constants.Impl.Biblio
{
    public class ConstantAuthor : ConstantAcronym<EntityAuthor>, IConstantAuthor
    {
        public override uint ConstantMaxAcronym => throw new NotImplementedException();

        public override uint ConstantMaxText => throw new NotImplementedException();

        private ConstantAuthor() { }

        public static IConstantAuthor Factory() => new ConstantAuthor();
    }
}
