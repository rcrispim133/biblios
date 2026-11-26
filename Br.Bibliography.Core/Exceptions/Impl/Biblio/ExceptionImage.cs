using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Exceptions.Impl.Biblio
{
    public class ExceptionImage : ExceptionRaw<EntityImage>, IExceptionImage
    {
        #region Constructor

        protected ExceptionImage(EntityImage? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionImage Factory(EntityImage? entity) => new(entity);

        #endregion
    }
}
