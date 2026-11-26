using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionPeriod : ExceptionText<EntityPeriod>, IExceptionPeriod
    {
        public override EntityPeriod? Entity { get; init; }

        public ExceptionPeriod(EntityPeriod? entity) : base(entity) { }
    }
}
