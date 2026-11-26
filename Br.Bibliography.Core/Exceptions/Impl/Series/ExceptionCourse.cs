using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionCourse : ExceptionAcronymDesc<EntityCourse>, IExceptionCourse
    {
        #region Constructor

        protected ExceptionCourse(EntityCourse? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionCourse Factory(EntityCourse? entity) => new(entity);

        #endregion
    }
}
