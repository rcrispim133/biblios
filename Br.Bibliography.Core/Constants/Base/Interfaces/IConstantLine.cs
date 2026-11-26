using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantLine<TEntity> : IConstantText<TEntity> where TEntity : class, IEntityLine<TEntity>, new()
    {
    }
}
