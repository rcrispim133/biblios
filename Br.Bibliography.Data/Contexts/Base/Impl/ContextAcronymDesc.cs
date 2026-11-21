using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextAcronymDesc<TEntity> : ContextAcronym<TEntity>, IContextAcronymDesc<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>
    {
        protected ContextAcronymDesc(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
