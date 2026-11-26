using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Interfaces
{
    public interface IExceptionAcronym<TEntity> : IExceptionText<TEntity> where TEntity : class, IEntityAcronym<TEntity>, new()
    {
    }
}
