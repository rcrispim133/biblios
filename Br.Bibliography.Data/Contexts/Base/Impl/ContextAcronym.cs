using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextAcronym<TEntity> : ContextText<TEntity>, IContextAcronym<TEntity> where TEntity : class, IEntityAcronym<TEntity>
    {
        protected ContextAcronym(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
