using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionBiblioLecture : ExceptionBase<EntityBiblioLecture>, IExceptionBiblioLecture
    {
        public override EntityBiblioLecture? Entity { get; init; }

        public ExceptionBiblioLecture(EntityBiblioLecture? entity) : base(entity) { }
    }
}
