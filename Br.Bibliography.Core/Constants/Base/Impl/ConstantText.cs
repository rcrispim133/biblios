using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantText<TEntity> : ConstantBase<TEntity>, IConstantText<TEntity> where TEntity : class, IEntityText<TEntity>, new()
    {
        public abstract uint ConstantMaxText { get; }
    }
}
