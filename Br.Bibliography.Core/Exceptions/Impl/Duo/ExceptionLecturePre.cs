using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionLecturePre : ExceptionBase<EntityLecturePre>, IExceptionLecturePre
    {
        public override EntityLecturePre? Entity { get; init; }

        public ExceptionLecturePre(EntityLecturePre? entity) : base(entity) { }
    }
}
