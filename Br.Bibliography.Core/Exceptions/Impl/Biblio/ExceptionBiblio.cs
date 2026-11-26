using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Exceptions.Impl.Biblio
{
    public class ExceptionBiblio : ExceptionBase<EntityBiblio>, IExceptionBiblio
    {
        public override EntityBiblio? Entity { get; init; }

        public ExceptionBiblio(EntityBiblio? entity) : base(entity) { }
    }
}
