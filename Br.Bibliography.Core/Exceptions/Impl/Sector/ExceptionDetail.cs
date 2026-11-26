using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Exceptions.Impl.Sector
{
    public class ExceptionDetail : ExceptionText<EntityDetail>, IExceptionDetail
    {
        public override EntityDetail? Entity { get; init; }

        public ExceptionDetail(EntityDetail? entity) : base(entity) { }
    }
}
