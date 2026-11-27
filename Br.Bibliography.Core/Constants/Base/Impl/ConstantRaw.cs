using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Util.Extensions;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantRaw<TEntity> : ConstantText<TEntity>, IConstantRaw<TEntity> where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region Text

        public int DefaultMaxRaw => ResourceBase.DefaultMaxRaw.Parse();

        #endregion
    }
}
