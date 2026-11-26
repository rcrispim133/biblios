using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionLecture : ExceptionAcronym<EntityLecture>, IExceptionLecture
    {
        public override EntityLecture? Entity { get; init; }

        public ExceptionLecture(EntityLecture? entity) : base(entity) { }
    }
}
