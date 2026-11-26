using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantDesc<TEntity> : ConstantBase<TEntity>, IConstantDesc<TEntity> where TEntity : class, IEntityDesc<TEntity>, new()
    {
        #region Desc

        public abstract int ConstantMaxDesc { get; }

        #endregion
    }
}
