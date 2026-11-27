using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;


namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextAcronymDesc<TEntity> : ContextAcronym<TEntity>, IContextAcronymDesc<TEntity> where TEntity : class, IEntityAcronymDesc<TEntity>
    {
        protected ContextAcronymDesc(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
