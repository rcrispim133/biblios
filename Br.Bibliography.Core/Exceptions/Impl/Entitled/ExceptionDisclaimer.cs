using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionDisclaimer : ExceptionDesc<EntityDisclaimer>, IExceptionDisclaimer
    {
        public override EntityDisclaimer? Entity { get; init; }

        public ExceptionDisclaimer(EntityDisclaimer? entity) : base(entity) { }
    }
}
