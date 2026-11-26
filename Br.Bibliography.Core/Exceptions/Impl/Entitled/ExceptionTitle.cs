using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionTitle : ExceptionText<EntityTitle>, IExceptionTitle
    {
        public override EntityTitle? Entity { get; init; }

        public ExceptionTitle(EntityTitle? entity) : base(entity) { }
    }
}
