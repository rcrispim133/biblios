using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionCycle : ExceptionText<EntityCycle>, IExceptionCycle
    {
        public override EntityCycle? Entity { get; init; }

        public ExceptionCycle(EntityCycle? entity) : base(entity) { }
    }
}
