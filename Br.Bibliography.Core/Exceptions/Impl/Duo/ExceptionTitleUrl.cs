using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionTitleUrl : ExceptionBase<EntityTitleUrl>, IExceptionTitleUrl
    {
        public override EntityTitleUrl? Entity { get; init; }

        public ExceptionTitleUrl(EntityTitleUrl? entity) : base(entity) { }
    }
}
