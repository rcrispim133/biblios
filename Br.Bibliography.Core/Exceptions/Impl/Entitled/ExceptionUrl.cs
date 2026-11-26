using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionUrl : ExceptionText<EntityUrl>, IExceptionUrl
    {
        public override EntityUrl? Entity { get; init; }

        public ExceptionUrl(EntityUrl? entity) : base(entity) { }
    }
}
