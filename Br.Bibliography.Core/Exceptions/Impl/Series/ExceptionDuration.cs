using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionDuration : ExceptionText<EntityDuration>, IExceptionDuration
    {
        public override EntityDuration? Entity { get; init; }

        public ExceptionDuration(EntityDuration? entity) : base(entity) { }
    }
}
