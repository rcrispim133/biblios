using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionBiblioAuthor : ExceptionBase<EntityBiblioAuthor>, IExceptionBiblioAuthor
    {
        public override EntityBiblioAuthor? Entity { get; init; }

        public ExceptionBiblioAuthor(EntityBiblioAuthor? entity) : base(entity) { }
    }
}
