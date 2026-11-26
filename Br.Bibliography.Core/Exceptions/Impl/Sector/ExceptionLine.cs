using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Exceptions.Impl.Sector
{
    public class ExceptionLine : ExceptionLine<EntityLine>, IExceptionLine
    {
        public override EntityLine? Entity { get; init; }

        public ExceptionLine(EntityLine? entity) : base(entity) { }
    }
}
