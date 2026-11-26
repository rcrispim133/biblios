using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionAcronymDesc<TEntity> : IExceptionAcronym<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>, new()
    {
    }
}
