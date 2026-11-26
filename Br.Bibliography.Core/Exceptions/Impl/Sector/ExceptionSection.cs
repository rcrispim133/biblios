using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Exceptions.Impl.Sector
{
    public class ExceptionSection : ExceptionBase<EntitySection>, IExceptionSection
    {
        public override EntitySection? Entity { get; init; }

        public ExceptionSection(EntitySection? entity) : base(entity) { }
    }
}
