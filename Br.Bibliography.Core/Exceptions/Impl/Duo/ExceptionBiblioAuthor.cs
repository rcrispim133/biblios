using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionBiblioAuthor : ExceptionBase<EntityBiblioAuthor>, IExceptionBiblioAuthor
    {
        #region Constructor

        protected ExceptionBiblioAuthor(EntityBiblioAuthor? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionBiblioAuthor Factory(EntityBiblioAuthor? entity) => new(entity);

        #endregion
    }
}
