using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Exceptions.Impl.Biblio
{
    public class ExceptionImage : ExceptionRaw<EntityImage>, IExceptionImage
    {
        public override EntityImage? Entity { get; init; }

        public ExceptionImage(EntityImage? entity) : base(entity) { }
    }
}
