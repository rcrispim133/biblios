using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Util.Extensions;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantText<TEntity> : ConstantBase<TEntity>, IConstantText<TEntity> where TEntity : class, IEntityText<TEntity>, new()
    {
        #region Text
        public int DefaultTextMaxLength => ResourceBase.DefaultTextMaxLength.Parse();

        #endregion
    }
}
