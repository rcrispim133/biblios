using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Core.Exceptions.Impl.Biblio
{
    public class ExceptionAuthor : ExceptionAcronym<EntityAuthor>, IExceptionAuthor
    {
        #region Constructor

        protected ExceptionAuthor(EntityAuthor? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionAuthor Factory(EntityAuthor? entity) => new(entity);

        #endregion
    }
}
