using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Exceptions.Impl.Biblio
{
    public class ExceptionBiblio : ExceptionBase<EntityBiblio>, IExceptionBiblio
    {
        #region Constructor

        protected ExceptionBiblio(EntityBiblio? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionBiblio Factory(EntityBiblio? entity) => new(entity);

        #endregion
    }
}
