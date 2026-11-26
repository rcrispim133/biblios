using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Core.Exceptions.Impl.Sector
{
    public class ExceptionLine : ExceptionLine<EntityLine>, IExceptionLine
    {
        #region Constructor

        protected ExceptionLine(EntityLine? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionLine Factory(EntityLine? entity) => new(entity);

        #endregion
    }
}
