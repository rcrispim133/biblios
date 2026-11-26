using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionTeacher : ExceptionText<EntityTeacher>, IExceptionTeacher
    {
        public override EntityTeacher? Entity { get; init; }

        public ExceptionTeacher(EntityTeacher? entity) : base(entity) { }
    }
}
