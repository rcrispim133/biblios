using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantRaw<TEntity> : ConstantText<TEntity>, IConstantRaw<TEntity> where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region Text

        public abstract int ConstantMaxRaw { get; }

        #endregion
    }
}
