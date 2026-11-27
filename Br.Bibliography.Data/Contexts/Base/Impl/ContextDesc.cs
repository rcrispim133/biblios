using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Base.Interfaces;


namespace Br.Bibliography.Data.Contexts.Base.Impl
{
    public abstract class ContextDesc<TEntity> : ContextBase<TEntity>, IContextDesc<TEntity> where TEntity : class, IEntityDesc<TEntity>
    {
        protected ContextDesc(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
