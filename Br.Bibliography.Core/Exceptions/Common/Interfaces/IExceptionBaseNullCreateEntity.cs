using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Common.Interfaces
{
    public interface IExceptionBaseNullCreateEntity<TEntity> : 
        IExceptionBase<TEntity> 
            where TEntity : class, IEntityBase<TEntity>, new()
    {
    }
    
}
