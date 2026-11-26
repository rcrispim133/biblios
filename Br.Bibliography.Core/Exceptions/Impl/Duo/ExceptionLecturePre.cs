using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionLecturePre : ExceptionBase<EntityLecturePre>, IExceptionLecturePre
    {
        #region Constructor

        protected ExceptionLecturePre(EntityLecturePre? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionLecturePre Factory(EntityLecturePre? entity) => new(entity);

        #endregion
    }
}
