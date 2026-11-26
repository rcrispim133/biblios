using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionBiblioImage : ExceptionBase<EntityBiblioImage>, IExceptionBiblioImage
    {
        public override EntityBiblioImage? Entity { get; init; }

        public ExceptionBiblioImage(EntityBiblioImage? entity) : base(entity) { }
    }
}
