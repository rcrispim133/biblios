using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Core.Exceptions.Impl.Entitled
{
    public class ExceptionTitle : ExceptionText<EntityTitle>, IExceptionTitle
    {
        #region Constructor

        protected ExceptionTitle(EntityTitle? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionTitle Factory(EntityTitle? entity) => new(entity);

        #endregion
    }
}
