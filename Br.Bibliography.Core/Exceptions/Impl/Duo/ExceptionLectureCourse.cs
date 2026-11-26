using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionLectureCourse : ExceptionBase<EntityLectureCourse>, IExceptionLectureCourse
    {
        public override EntityLectureCourse? Entity { get; init; }

        public ExceptionLectureCourse(EntityLectureCourse? entity) : base(entity) { }
    }
}
