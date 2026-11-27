using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Br.Bibliography.Util.Extensions.Impl;
using Br.Bibliography.Util.Resources;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantDesc<TEntity> : ConstantBase<TEntity>, IConstantDesc<TEntity> where TEntity : class, IEntityDesc<TEntity>, new()
    {
        #region Desc

        public int DefaultMaxDesc => ResourceBase.DefaultMaxDesc.ParseFromResource();

        #endregion
    }
}
