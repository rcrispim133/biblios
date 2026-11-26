using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Core.Exceptions.Impl.Duo
{
    public class ExceptionLectureCourse : ExceptionBase<EntityLectureCourse>, IExceptionLectureCourse
    {
        #region Constructor

        protected ExceptionLectureCourse(EntityLectureCourse? entity) : base(entity) { }

        #endregion

        #region Factory
        
        public static ExceptionLectureCourse Factory(EntityLectureCourse? entity) => new(entity);

        #endregion
    }
}
