using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionLanguage : ExceptionText<EntityLanguage>, IExceptionLanguage
    {
        #region Constructor

        protected ExceptionLanguage(EntityLanguage? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionLanguage Factory(EntityLanguage? entity) => new(entity);

        #endregion
    }
}
