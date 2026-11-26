using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionWork : ExceptionText<EntityWork>, IExceptionWork
    {
        public override EntityWork? Entity { get; init; }

        public ExceptionWork(EntityWork? entity) : base(entity) { }
    }
}
