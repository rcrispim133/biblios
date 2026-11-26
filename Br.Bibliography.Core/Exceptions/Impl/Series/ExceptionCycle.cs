using Br.Bibliography.Core.Exceptions.Base.Impl;
using Br.Bibliography.Core.Exceptions.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Core.Exceptions.Impl.Series
{
    public class ExceptionCycle : ExceptionText<EntityCycle>, IExceptionCycle
    {
        #region Constructor

        protected ExceptionCycle(EntityCycle? entity) : base(entity) { }

        #endregion

        #region Factory

        public static ExceptionCycle Factory(EntityCycle? entity) => new(entity);

        #endregion
    }
}
