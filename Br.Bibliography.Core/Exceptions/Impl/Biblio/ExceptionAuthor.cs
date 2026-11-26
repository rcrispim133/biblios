using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Exceptions.Impl.Biblio
{
    public class ExceptionAuthor : ExceptionAcronym<EntityAuthor>, IExceptionAuthor
    {
        public override EntityAuthor? Entity { get; init; }

        public ExceptionAuthor(EntityAuthor? entity) : base(entity) { }
    }
}
