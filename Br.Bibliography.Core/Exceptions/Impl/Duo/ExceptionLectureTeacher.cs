using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionLectureTeacher : ExceptionBase<EntityLectureTeacher>, IExceptionLectureTeacher
    {
        public override EntityLectureTeacher? Entity { get; init; }

        public ExceptionLectureTeacher(EntityLectureTeacher? entity) : base(entity) { }
    }
}
