using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionBiblioLecture : ExceptionBase<EntityBiblioLecture>, IExceptionBiblioLecture
    {
        #region Constructor

        protected ExceptionBiblioLecture(EntityBiblioLecture? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionBiblioLecture Factory(EntityBiblioLecture? entity) => new(entity);

        #endregion
    }
}
