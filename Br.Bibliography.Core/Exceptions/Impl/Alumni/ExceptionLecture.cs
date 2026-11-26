using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Core.Exceptions.Impl.Alumni
{
    public class ExceptionLecture : ExceptionAcronym<EntityLecture>, IExceptionLecture
    {
        #region Constructor

        protected ExceptionLecture(EntityLecture? entity) : base(entity) { }
        
        #endregion

        #region Factory

        public static ExceptionLecture Factory(EntityLecture? entity) => new(entity);

        #endregion
    }
}
