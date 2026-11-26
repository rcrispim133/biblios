using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionPublisher : ExceptionText<EntityPublisher>, IExceptionPublisher
    {
        public override EntityPublisher? Entity { get; init; }

        public ExceptionPublisher(EntityPublisher? entity) : base(entity) { }
    }
}
