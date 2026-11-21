using Br.Bibliography.Data.Contexts.Base;
using Br.Bibliography.Data.Contexts.Base.Impl;
using Br.Bibliography.Data.Contexts.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Contexts.Impl.Locals
{
    public class ContextCountry : ContextText<EntityCountry>, IContextCountry
    {
        #region Properties

        public override DbSet<EntityCountry> DbSet { get; init; }

        #endregion

        #region Constructor

        public ContextCountry(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion
    }
}
