using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Exceptions.Impl.Sector
{
    public class ExceptionSection : ExceptionBase<EntitySection>, IExceptionSection
    {
        #region Constructor

        protected ExceptionSection(EntitySection? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionSection Factory(EntitySection? entity) => new(entity);

        #endregion
    }
}
