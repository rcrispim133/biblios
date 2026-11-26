using Br.Bibliography.Core.Exceptions.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Exceptions.Base.Impl
{
    public abstract class ExceptionAcronym<TEntity> : 
        ExceptionText<TEntity>, 
        IExceptionAcronym<TEntity> 
            where TEntity : class, IEntityAcronym<TEntity>, new()
    {
        protected ExceptionAcronym(TEntity? entity) : base(entity) { }
    }
}
