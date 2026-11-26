using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantDesc<TEntity> : IConstantBase<TEntity> where TEntity : class, IEntityDesc<TEntity>, new()
    {
        uint ConstantMaxDesc { get; }
    }
}
