using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionCourse : ExceptionAcronymDesc<EntityCourse>, IExceptionCourse
    {
        public override EntityCourse? Entity { get; init; }

        public ExceptionCourse(EntityCourse? entity) : base(entity) { }
    }
}
