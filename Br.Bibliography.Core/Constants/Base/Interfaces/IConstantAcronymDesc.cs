using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantAcronymDesc<TEntity> : IConstantAcronym<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>, new()
    {
    }
}
