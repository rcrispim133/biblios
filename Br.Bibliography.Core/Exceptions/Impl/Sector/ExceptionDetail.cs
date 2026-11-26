using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Exceptions.Impl.Sector
{
    public class ExceptionDetail : ExceptionText<EntityDetail>, IExceptionDetail
    {
        #region Constructor

        protected ExceptionDetail(EntityDetail? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionDetail Factory(EntityDetail? entity) => new(entity);

        #endregion
    }
}
