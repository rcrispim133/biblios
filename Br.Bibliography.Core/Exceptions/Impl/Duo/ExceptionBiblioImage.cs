using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionBiblioImage : ExceptionBase<EntityBiblioImage>, IExceptionBiblioImage
    {
        #region Constructor

        protected ExceptionBiblioImage(EntityBiblioImage? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionBiblioImage Factory(EntityBiblioImage? entity) => new(entity);

        #endregion
    }
}