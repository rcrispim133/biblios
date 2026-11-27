using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;


namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextAcronym<TEntity> : ContextText<TEntity>, IContextAcronym<TEntity> where TEntity : class, IEntityAcronym<TEntity>
    {
        protected ContextAcronym(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
