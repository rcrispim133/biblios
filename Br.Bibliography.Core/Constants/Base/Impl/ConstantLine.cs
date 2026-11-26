using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantLine<TEntity> : ConstantText<TEntity>, IConstantLine<TEntity> where TEntity : class, IEntityLine<TEntity>, new()
    {
    }
}
