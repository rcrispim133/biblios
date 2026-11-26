using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionUnit : ExceptionAcronym<EntityUnit>, IExceptionUnit
    {
        public override EntityUnit? Entity { get; init; }

        public ExceptionUnit(EntityUnit? entity) : base(entity) { }
    }
}
