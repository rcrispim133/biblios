using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionYear : ExceptionBase<EntityYear>, IExceptionYear
    {
        public override EntityYear? Entity { get; init; }

        public ExceptionYear(EntityYear? entity) : base(entity) { }
    }
}
